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

        builder.Property(i => i.AuthorName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(i => i.OrganizationName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(i => i.OrganizationEmail)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(i => i.TechnologyName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(i => i.ProductName)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasGeneratedTsVectorColumn(
                i => i.SearchVector,
                "russian",
                i => new { i.AuthorName, i.OrganizationName, i.TechnologyName })
            .HasIndex(i => i.SearchVector)
            .HasMethod("GIN");

        var innovationFaker = new Faker<Innovation>("ru")
            .RuleFor(i => i.Id, f => f.IndexFaker + 1)
            .RuleFor(i => i.AuthorName, f => f.Name.FirstName() + " " + f.Name.LastName())
            .RuleFor(i => i.OrganizationEmail, f => f.Internet.Email().ToLower())
            .RuleFor(i => i.TechnologyName, f => f.PickRandom(new[]
            {
                "Нейросеть",
                "Квантовые вычисления",
                "ИИ",
                "Машинное обучение",
                "IoT платформа",
                "Доставка",
                "Распознавание речи"
            }))
            .RuleFor(i => i.ProductName, f => f.PickRandom(new[]
            {
                "Программное обеспечение",
                "Аналитическая платформа",
                "Сенсор",
                "Процессор",
                "Система мониторинга",
                "Устройство связи",
                "Графический чип"
            }))
            .RuleFor(i => i.OrganizationName, f => f.PickRandom(new[]
            {
                "ТехноСтар",
                "ИнноТех",
                "ГиперСофт",
                "РобоТех",
                "СофтТек",
                "МегаТехнологии",
                "ИнфоСистемы",
                "НаноТех",
                "ГлобалТех",
                "ИнтелСистемы"
            }))
            .RuleFor(i => i.DateTime, f => f.Date.Past(5, DateTime.UtcNow));

        var innovations = innovationFaker.Generate(60);

        builder.HasData(innovations);
    }
}