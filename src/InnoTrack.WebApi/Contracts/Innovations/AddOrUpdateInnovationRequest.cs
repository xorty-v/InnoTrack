namespace InnoTrack.WebApi.Contracts.Innovations;

public record AddOrUpdateInnovationRequest(
    string AuthorName,
    string OrganizationName,
    string OrganizationEmail,
    string TechnologyName,
    string ProductName,
    DateTime DateTime
);