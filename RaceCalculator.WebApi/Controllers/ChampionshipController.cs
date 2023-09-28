using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using RaceCalculator.Application.Championships.Commands.CreateChampionship;
using RaceCalculator.Application.Championships.Commands.DeleteChampionship;
using RaceCalculator.Application.Championships.Commands.UpdateChampionship;
using RaceCalculator.Application.Championships.Queries.GetChampionshipDetails;
using RaceCalculator.Application.Championships.Queries.GetChampionshipList;
using RaceCalculator.WebApi.Models;

namespace RaceCalculator.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ChampionshipController : BaseController
    {
        private readonly IMapper _mapper;
        public ChampionshipController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<ChampionshipListVm>> GetAll()
        {
            var query = new GetChampionshipListQuerie()
            {
                Id = Id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionshipDetailsVm>> Get(Guid id)
        {
            var query = new GetChampionshipDetailsQuerie()
            {
                Id = Id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateChampionshipDto createChampionshipDto)
        {
            var command        = _mapper.Map<CreateChampionshipCommand>(createChampionshipDto);
            command.Id         = Id;
            var championshipId = await Mediator.Send(command);
            return Ok(championshipId);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateChampionshipDto updateChampionshipDto)
        {
            var command = _mapper.Map<UpdateChampionshipCommand>(updateChampionshipDto);
            command.Id = Id;
            var championshipId = await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var command = new DeleteChampionshipCommand() 
            { 
                Id = Id 
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
