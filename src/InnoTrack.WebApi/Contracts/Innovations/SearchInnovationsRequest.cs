namespace InnoTrack.WebApi.Contracts.Innovations;

public record SearchInnovationsRequest(string SearchQuery) : BasePaginationRequest;