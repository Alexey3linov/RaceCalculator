using AutoMapper;

using RaceCalculator.Application.Championships.Commands.CreateChampionship;
using RaceCalculator.Application.Championships.Commands.UpdateChampionship;
using RaceCalculator.Application.Common.Mappings;
using RaceCalculator.Domain;

namespace RaceCalculator.WebApi.Models
{
    public class UpdateChampionshipDto : IMapWith<UpdateChampionshipCommand>
    {
        public Guid                    Id { get; set; }
        public string                  Title { get; set; }
        public DateTime                StartDate { get; set; }
        public IEnumerable<Stage>      StageList { get; set; }
        public IEnumerable<Nomination> NominationList { get; set; }
        public IEnumerable<Competitor> CompetitorList { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateChampionshipDto, UpdateChampionshipCommand>().
                ForMember(championshipCommand => championshipCommand.Id,
                    opt => opt.MapFrom(championshipDto => championshipDto.Id)).
                ForMember(championshipCommand => championshipCommand.Title,
                    opt => opt.MapFrom(championshipDto => championshipDto.Title)).
                ForMember(championshipCommand => championshipCommand.StartDate,
                    opt => opt.MapFrom(championshipDto => championshipDto.StartDate)).
                ForMember(championshipCommand => championshipCommand.StageList,
                    opt => opt.MapFrom(championshipDto => championshipDto.StageList)).
                ForMember(championshipCommand => championshipCommand.NominationList,
                    opt => opt.MapFrom(championshipDto => championshipDto.NominationList)).
                ForMember(championshipCommand => championshipCommand.CompetitorList,
                    opt => opt.MapFrom(championshipDto => championshipDto.CompetitorList));
        }
    }
}
