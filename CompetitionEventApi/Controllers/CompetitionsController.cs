using AutoMapper;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services.DataObjects;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CompetitionEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionsController : ControllerBase
    {
        private readonly ICompetitionService _competitionService;
        private readonly IMapper _mapper;

        public CompetitionsController(ICompetitionService competitionService, IMapper mapper)
        {
            _competitionService = competitionService;
            _mapper = mapper;
        }

        // GET: api/Competitions
        [HttpGet]
        public IEnumerable<CompetitionViewModel> GetCompetitions()
        {
            return _mapper.Map<List<CompetitionViewModel>>(_competitionService.GetAll());
        }

        // GET: api/Competitions/5
        [HttpGet("{id}")]
        public IActionResult GetCompetition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var competitionViewModel = _mapper.Map<CompetitionViewModel>(_competitionService.GetById(id));

            if (competitionViewModel == null)
            {
                return NotFound();
            }

            return Ok(competitionViewModel);
        }

        // POST: api/Competitions
        [HttpPost]
        public IActionResult PostCompetition([FromBody] CompetitionViewModel competition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _competitionService.Save(_mapper.Map<Competition>(competition));

            return new JsonResult(competition);
        }

        // DELETE: api/Competitions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCompetition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var competition = _competitionService.GetById(id);

            if (competition == null)
            {
                return NotFound();
            }

            competition.Status = Status.Deleted;

            _competitionService.Save(competition);

            return Ok(competition);
        }

        private bool CompetitionExists(int id)
        {
            return _competitionService.GetAll().Any(e => e.Id == id);
        }
    }
}