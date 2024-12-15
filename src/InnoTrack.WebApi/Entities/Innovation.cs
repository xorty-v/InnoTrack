using NpgsqlTypes;

namespace InnoTrack.WebApi.Entities;

public class Innovation
{
    public int Id { get; set; }

    public string AuthorName { get; set; }
    public string OrganizationName { get; set; }
    public string OrganizationEmail { get; set; }
    public string TechnologyName { get; set; }
    public string ProductName { get; set; }
    public DateTime DateTime { get; set; }

    public NpgsqlTsVector SearchVector { get; set; }
}