using AutoMapper;
using InnoTrack.WebApi.Contracts;
using InnoTrack.WebApi.Contracts.Innovations;
using InnoTrack.WebApi.Entities;
using InnoTrack.WebApi.Persistence.Repository;
using InnoTrack.WebApi.Services.Exceptions;

namespace InnoTrack.WebApi.Services;

public class InnovationService : IInnovationService
{
    private readonly IInnovationRepository _innovationRepository;
    private readonly IReportService _pdfReportService;
    private readonly IMapper _mapper;

    public InnovationService(IInnovationRepository innovationRepository, IMapper mapper, IReportService reportService)
    {
        _innovationRepository = innovationRepository;
        _mapper = mapper;
        _pdfReportService = reportService;
    }

    public async Task<PaginatedResponse<GetInnovationResponse>> GetAllInnovationsAsync(GetInnovationsRequest request,
        CancellationToken cancellationToken)
    {
        var innovations = await _innovationRepository.GetAllAsync(request.PageNumber, request.PageSize,
            cancellationToken);

        return new PaginatedResponse<GetInnovationResponse>(
            _mapper.Map<List<GetInnovationResponse>>(innovations.Items),
            innovations.TotalCount,
            innovations.CurrentPage,
            innovations.PageSize);
    }

    public async Task<PaginatedResponse<GetInnovationResponse>> SearchInnovationsAsync(SearchInnovationsRequest request,
        CancellationToken cancellationToken)
    {
        var innovations = await _innovationRepository.SearchAsync(request.PageNumber, request.PageSize,
            request.SearchQuery, cancellationToken);

        return new PaginatedResponse<GetInnovationResponse>(
            _mapper.Map<List<GetInnovationResponse>>(innovations.Items),
            innovations.TotalCount,
            innovations.CurrentPage,
            innovations.PageSize);
    }

    public async Task<byte[]> GeneratePdf(int id, CancellationToken cancellationToken)
    {
        var innovation = await _innovationRepository.GetByIdAsync(id, cancellationToken);

        if (innovation == null)
        {
            throw new InnovationNotFoundException();
        }

        return _pdfReportService.GenerateReport(
            innovation.AuthorName,
            innovation.OrganizationName,
            innovation.OrganizationEmail,
            innovation.TechnologyName,
            innovation.ProductName,
            innovation.DateTime.Year);
    }

    public async Task AddInnovationAsync(AddOrUpdateInnovationRequest request, CancellationToken cancellationToken)
    {
        var innovation = _mapper.Map<Innovation>(request);

        await _innovationRepository.AddAsync(innovation, cancellationToken);
    }

    public async Task UpdateInnovationAsync(int id, AddOrUpdateInnovationRequest request,
        CancellationToken cancellationToken)
    {
        var innovation = await _innovationRepository.GetByIdAsync(id, cancellationToken);

        if (innovation == null)
        {
            throw new InnovationNotFoundException();
        }

        innovation = _mapper.Map<Innovation>(request);
        innovation.Id = id;

        await _innovationRepository.UpdateAsync(innovation, cancellationToken);
    }

    public async Task DeleteInnovationAsync(int id, CancellationToken cancellationToken)
    {
        var innovation = await _innovationRepository.GetByIdAsync(id, cancellationToken);

        if (innovation == null)
        {
            throw new InnovationNotFoundException();
        }

        await _innovationRepository.DeleteAsync(innovation, cancellationToken);
    }
}