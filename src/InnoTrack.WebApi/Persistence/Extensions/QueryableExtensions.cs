using InnoTrack.WebApi.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InnoTrack.WebApi.Persistence.Extensions;

public static class QueryableExtensions
{
    public static async Task<PaginatedResponse<T>> ToPaginatedResponse<T>(
        this IQueryable<T> source,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var count = await source.CountAsync(cancellationToken);
        var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);

        return new PaginatedResponse<T>(items, count, pageNumber, pageSize);
    }
}