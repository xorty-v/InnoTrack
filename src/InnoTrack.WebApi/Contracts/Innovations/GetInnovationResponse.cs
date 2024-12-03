namespace InnoTrack.WebApi.Contracts.Innovations;

public record GetInnovationResponse(
    int Id,
    string AuthorName,
    string OrganizationName,
    string OrganizationEmail,
    string TechnologyName,
    string ProductName,
    DateTime DateTime
);