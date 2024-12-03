using InnoTrack.WebApi.Contracts;
using InnoTrack.WebApi.Contracts.Innovations;

namespace InnoTrack.WebApi.Services;

public interface IInnovationService
{
    public Task<PaginatedResponse<GetInnovationResponse>> GetAllInnovationsAsync(GetInnovationsRequest request,
        CancellationToken cancellationToken);

    public Task<PaginatedResponse<GetInnovationResponse>> SearchInnovationsAsync(SearchInnovationsRequest request,
        CancellationToken cancellationToken);

    public Task<byte[]> GeneratePdf(int id, CancellationToken cancellationToken);
    public Task AddInnovationAsync(AddOrUpdateInnovationRequest request, CancellationToken cancellationToken);

    public Task UpdateInnovationAsync(int id, AddOrUpdateInnovationRequest request,
        CancellationToken cancellationToken);

    public Task DeleteInnovationAsync(int id, CancellationToken cancellationToken);
}