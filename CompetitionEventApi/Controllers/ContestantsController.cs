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
        private readonly ICompetitionApplicationService _competitionApplicationService;
        private readonly IMailService _mailService;

        public ContestantsController(
            IContestantService contestantService,
            ICompetitionEventService competitionEventService,
            ICompetitionService competitionService,
            IMapper mapper,
            ICompetitionApplicationService competitionApplicationService,
            IMailService mailService)
        {
            _contestantService = contestantService;
            _competitionEventService = competitionEventService;
            _mapper = mapper;
            _competitionService = competitionService;
            _competitionApplicationService = competitionApplicationService;
            _mailService = mailService;
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

            var contestant = _mapper.Map<Contestant>(contestantViewModel);

            if (_contestantService.Save(contestant))
            {
                string comeptitionNames = "";
                foreach (var item in contestantViewModel.RelatedCompetitionIds)
                {
                    var competition = _competitionService.GetById(item);

                    var competitionApplication = new CompetitionApplication
                    {
                        Contestant = contestant,
                        Competition = competition
                    };

                    comeptitionNames += competition.Title + "<br/>";

                    _competitionApplicationService.Save(competitionApplication);
                }

                string message = "Bok " + contestant.FirstName + " " + contestant.LastName
                                    + "!<br/><br/> Vaša prijava je zaprimljena te Vam je dodijeljen broj <b>#"
                                    + contestant.Id
                                    + "</b> <br/><br/> Molimo Vas da ovaj mail sa brojem čuvate kao potvrdu za drugi dio prijava(check-in) na samom natjecanju"
                                    + "<br/><br/> Prijavljena natjecanja: <br/>" + comeptitionNames + "<br/>"
                                    + "<br/><br/>"
                                    + "Hvala na prijavi i vidimo se!";

                _mailService.SendMail(message, contestant.Email);
            }

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