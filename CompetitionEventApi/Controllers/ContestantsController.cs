using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompetitionEventApi.Services;
using CompetitionEventApi.Services.DataObjects;
using AutoMapper;
using CompetitionEventApi.Services.Interfaces;
using CompetitionEventApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace CompetitionEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContestantsController : ControllerBase
    {
        private readonly IContestantService _contestantService;
        private readonly ICompetitionEventService _competitionEventService;
        private readonly ICompetitionService _competitionService;
        private readonly IMapper _mapper;

        public ContestantsController(
            IContestantService contestantService,
            ICompetitionEventService competitionEventService,
            ICompetitionService competitionService,
            IMapper mapper)
        {
            _contestantService = contestantService;
            _competitionEventService = competitionEventService;
            _mapper = mapper;
            _competitionService = competitionService;
        }


        // GET: api/Contestants
        [HttpGet]
        public IEnumerable<ContestantViewModel> GetContestants()
        {
            return _mapper.Map<List<ContestantViewModel>>(_contestantService.GetAll());
        }

        // GET: api/Contestants/5
        [HttpGet("{id}")]
        public IActionResult GetContestant([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contestantViewModel = _mapper.Map<ContestantViewModel>(_contestantService.GetById(id));

            if (contestantViewModel == null)
            {
                return NotFound();
            }

            return Ok(contestantViewModel);
        }

        // POST: api/Contestants
        [HttpPost]
        public IActionResult PostContestant([FromBody] ContestantViewModel contestantViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _contestantService.Save(_mapper.Map<Contestant>(contestantViewModel));

            return new JsonResult(contestantViewModel);
        }

        // DELETE: api/Contestants/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCompetition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contestant = _contestantService.GetById(id);

            if (contestant == null)
            {
                return NotFound();
            }

            contestant.Status = Status.Deleted;

            _contestantService.Save(contestant);

            return Ok(contestant);
        }

        private bool ContestantExists(int id)
        {
            return _contestantService.GetAll().Any(e => e.Id == id);
        }
    }
}