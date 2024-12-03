using AutoMapper;
using InnoTrack.WebApi.Contracts.Innovations;
using InnoTrack.WebApi.Entities;

namespace InnoTrack.WebApi.Services.MapProfiles;

public class MapProfileInnovations : Profile
{
    public MapProfileInnovations()
    {
        CreateMap<Innovation, GetInnovationResponse>()
            .ConstructUsing(src => new GetInnovationResponse(
                src.Id,
                src.AuthorName,
                src.OrganizationName,
                src.OrganizationEmail,
                src.TechnologyName,
                src.ProductName,
                src.DateTime
            ));
        
        CreateMap<AddOrUpdateInnovationRequest, Innovation>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}