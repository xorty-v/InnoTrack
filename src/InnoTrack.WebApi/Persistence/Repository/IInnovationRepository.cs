using InnoTrack.WebApi.Contracts;
using InnoTrack.WebApi.Entities;

namespace InnoTrack.WebApi.Persistence.Repository;

public interface IInnovationRepository
{
    public Task<PaginatedResponse<Innovation>> GetAllAsync(int pageNumber, int pageSize,
        CancellationToken cancellationToken);

    public Task<PaginatedResponse<Innovation>> SearchAsync(int pageNumber, int pageSize, string searchQuery,
        CancellationToken cancellationToken);

    public Task<Innovation> GetByIdAsync(int id, CancellationToken cancellationToken);
    public Task AddAsync(Innovation innovation, CancellationToken cancellationToken);
    public Task UpdateAsync(Innovation innovation, CancellationToken cancellationToken);
    public Task DeleteAsync(Innovation innovation, CancellationToken cancellationToken);
}