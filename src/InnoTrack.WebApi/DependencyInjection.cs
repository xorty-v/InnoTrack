using FluentValidation;
using FluentValidation.AspNetCore;
using InnoTrack.WebApi.Persistence;
using InnoTrack.WebApi.Persistence.Repository;
using InnoTrack.WebApi.Services;
using InnoTrack.WebApi.Services.MapProfiles;
using InnoTrack.WebApi.Services.Validations;
using Microsoft.EntityFrameworkCore;
using LicenseType = QuestPDF.Infrastructure.LicenseType;

namespace InnoTrack.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        services.AddValidatorsFromAssemblyContaining<AddOrUpdateInnovationRequestValidator>();
        services.AddFluentValidationAutoValidation();

        services.AddScoped<IInnovationService, InnovationService>();
        services.AddScoped<IReportService, PdfReportService>();

        services.AddAutoMapper(cfg => cfg.AddProfile<MapProfileInnovations>());

        return services;
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IInnovationRepository, InnovationRepository>();

        return services;
    }
}