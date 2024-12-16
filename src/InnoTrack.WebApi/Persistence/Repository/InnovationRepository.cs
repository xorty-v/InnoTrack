using InnoTrack.WebApi.Contracts;
using InnoTrack.WebApi.Entities;
using InnoTrack.WebApi.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace InnoTrack.WebApi.Persistence.Repository;

public class InnovationRepository : IInnovationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public InnovationRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PaginatedResponse<Innovation>> GetAllAsync(int pageNumber, int pageSize,
        CancellationToken cancellationToken)
    {
        return await _dbContext.Innovations
            .OrderByDescending(i => i.DateTime)
            .ToPaginatedResponse(pageNumber, pageSize, cancellationToken);
    }

    public async Task<PaginatedResponse<Innovation>> SearchAsync(int pageNumber, int pageSize, string searchQuery,
        CancellationToken cancellationToken)
    {
        return await _dbContext.Innovations
            .AsNoTracking()
            .Where(i => i.SearchVector.Matches(EF.Functions.PhraseToTsQuery("russian", searchQuery)))
            .ToPaginatedResponse(pageNumber, pageSize, cancellationToken);
    }

    public async Task<Innovation> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _dbContext.Innovations
            .AsNoTracking()
            .SingleOrDefaultAsync(i => i.Id == id, cancellationToken);
    }

    public async Task AddAsync(Innovation innovation, CancellationToken cancellationToken)
    {
        _dbContext.Innovations.Add(innovation);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(Innovation innovation, CancellationToken cancellationToken)
    {
        _dbContext.Innovations.Update(innovation);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Innovation innovation, CancellationToken cancellationToken)
    {
        _dbContext.Innovations.Remove(innovation);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}