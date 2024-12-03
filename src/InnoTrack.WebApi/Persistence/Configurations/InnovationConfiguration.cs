using Bogus;
using InnoTrack.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InnoTrack.WebApi.Persistence.Configurations;

public class InnovationConfiguration : IEntityTypeConfiguration<Innovation>
{
    public void Configure(EntityTypeBuilder<Innovation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasGeneratedTsVectorColumn(
                i => i.SearchVector,
                "english",
                i => new { i.AuthorName, i.ProductName, i.TechnologyName, i.OrganizationName })
            .HasIndex(i => i.SearchVector)
            .HasMethod("GIN");

        var innovationFaker = new Faker<Innovation>()
            .RuleFor(i => i.Id, f => f.IndexFaker + 1)
            .RuleFor(i => i.AuthorName, f => f.Name.FullName())
            .RuleFor(i => i.OrganizationName, f => f.Company.CompanyName())
            .RuleFor(i => i.OrganizationEmail, f => f.Internet.Email().ToLower())
            .RuleFor(i => i.TechnologyName, f => f.Commerce.Product())
            .RuleFor(i => i.ProductName, f => f.Commerce.ProductName())
            .RuleFor(i => i.DateTime, f => DateTime.UtcNow);

        List<Innovation> innovations = innovationFaker.Generate(60);

        builder.HasData(innovations);
    }
}