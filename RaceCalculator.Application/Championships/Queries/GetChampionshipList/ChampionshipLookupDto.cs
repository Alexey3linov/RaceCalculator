using AutoMapper;

using RaceCalculator.Application.Common.Mappings;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Queries.GetChampionshipList
{
    public class ChampionshipLookupDto : IMapWith<Championship>
    {
        public int    Id    { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Championship, ChampionshipLookupDto>()
                .ForMember(champVm => champVm.Id, opt => opt.MapFrom(champ => champ.Id))
                .ForMember(champVm => champVm.Title, opt => opt.MapFrom(champ => champ.Title));
        }
    }
}
