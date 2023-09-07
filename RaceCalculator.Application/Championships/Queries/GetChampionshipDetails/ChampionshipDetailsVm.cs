using AutoMapper;

using RaceCalculator.Application.Common.Mappings;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Queries.GetChampionshipDetails
{
    public class ChampionshipDetailsVm : IMapWith<Championship>
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public IEnumerable<Stage> StageList { get; set; } = null!;
        public IEnumerable<Nomination> NominationList { get; set; } = null!;
        public IEnumerable<Competitor> CompetitorList { get; set; } = null!;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Championship, ChampionshipDetailsVm>()
                .ForMember(champVm => champVm.Id, opt => opt.MapFrom(champ => champ.Id))
                .ForMember(champVm => champVm.Title, opt => opt.MapFrom(champ => champ.Title))
                .ForMember(champVm => champVm.StartDate, opt => opt.MapFrom(champ => champ.StartDate))
                .ForMember(champVm => champVm.StageList, opt => opt.MapFrom(champ => champ.StageList))
                .ForMember(champVm => champVm.NominationList, opt => opt.MapFrom(champ => champ.NominationList))
                .ForMember(champVm => champVm.CompetitorList, opt => opt.MapFrom(champ => champ.CompetitorList));
        }
    }
}
