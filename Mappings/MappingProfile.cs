using AutoMapper;
using FribergHomez.Controllers;
using FribergHomez.Models;

namespace FribergHomez.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //Peter

            //SaleObject
            CreateMap<SaleObject, SalesObjectDto>()
            //.ForMember(sODto => sODto.ConstructionYear, opt => opt.MapFrom(s => s.YearOfConstruction))
            //.ForMember(sODto => sODto.AnnualOperatingCost, opt => opt.MapFrom(s => s.OperatingCostPerYear))
            .ReverseMap();

            //RealEstateAgent
            CreateMap<RealEstateAgent, AgentDto>()
                //.ForMember(agentDto => agentDto.Id, opt => opt.MapFrom(s => s.Id))
                .ReverseMap();


        }
    }
}
