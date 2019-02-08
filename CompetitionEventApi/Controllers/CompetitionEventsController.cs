using AutoMapper;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services;
using CompetitionEventApi.Services.DataObjects;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionEventsController : ControllerBase
    {
        private readonly ICompetitionEventService _competitionEventService;
        private readonly ICompetitionService _competitionService;
        private readonly IMapper _mapper;

        public CompetitionEventsController(
            ICompetitionEventService competitionEventService,
            ICompetitionService competitionService,
            IMapper mapper)
        {
            _competitionEventService = competitionEventService;
            _mapper = mapper;
            _competitionService = competitionService;
        }

        // GET: api/CompetitionEvents
        [HttpGet]
        public IEnumerable<CompetitionEventViewModel> GetCompetitionEvents()
        {
            return _mapper.Map<List<CompetitionEventViewModel>>(_competitionEventService.GetAll());
        }

        // GET: api/CompetitionEvents/5
        [HttpGet("{id}")]
        public IActionResult GetCompetitionEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var competitionEvent = _competitionEventService.GetById(id);

            var competitionEventViewModel = _mapper.Map<CompetitionEventViewModel>(competitionEvent);

            if (competitionEvent == null)
            {
                return NotFound();
            }
            
            if(competitionEvent.RelatedEventCompetitions != null && competitionEvent.RelatedEventCompetitions.Count() > 0)
            {
                competitionEventViewModel.RelatedCompetitionIds = competitionEvent.RelatedEventCompetitions.Select(x => x.Id).ToArray();
            }
            return Ok(competitionEventViewModel);
        }

        // POST: api/Competitions
        [HttpPost]
        public IActionResult PostCompetitionEvent([FromBody] CompetitionEventViewModel competitionEventViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var competitionEvent = _mapper.Map<CompetitionEvent>(competitionEventViewModel);

            if (_competitionEventService.Save(competitionEvent))
            {
                if (competitionEventViewModel.RelatedCompetitionIds.Count() > 0)
                {
                    foreach (var item in competitionEventViewModel.RelatedCompetitionIds)
                    {
                        RelatedEventCompetition relatedEventCompetition = new RelatedEventCompetition
                        {
                            Competition = _competitionService.GetById(item),
                            CompetitionEvent = competitionEvent
                        };

                        _competitionEventService.SaveRelatedEventCompetition(relatedEventCompetition);
                    }
                }
            }

            return Ok(competitionEvent);
        }

        // DELETE: api/Competitions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCompetition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var competitionEvent = _competitionEventService.GetById(id);

            if (competitionEvent == null)
            {
                return NotFound();
            }

            competitionEvent.Status = Status.Deleted;

            _competitionEventService.Save(competitionEvent);

            return Ok(competitionEvent);
        }

        private bool CompetitionEventExists(int id)
        {
            return _competitionEventService.GetAll().Any(e => e.Id == id);
        }
    }
}