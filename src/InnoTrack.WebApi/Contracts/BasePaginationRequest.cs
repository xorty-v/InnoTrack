namespace InnoTrack.WebApi.Contracts;

public abstract record BasePaginationRequest
{
    private const int MaxPageNumber = 50;
    private int _pageNumber = 1;

    public int PageSize { get; init; } = 12;

    public int PageNumber
    {
        get => _pageNumber;
        init => _pageNumber = value > MaxPageNumber ? MaxPageNumber : value;
    }
}

public class PaginatedResponse<T>
{
    public int CurrentPage { get; private set; }
    public int TotalPages { get; private set; }
    public int PageSize { get; private set; }
    public int TotalCount { get; private set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;
    public List<T> Items { get; private set; }

    public PaginatedResponse(List<T> items, int count, int pageNumber, int pageSize)
    {
        TotalCount = count;
        PageSize = pageSize;
        CurrentPage = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        Items = items;
    }
}