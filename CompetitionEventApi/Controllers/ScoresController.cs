using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services.DataObjects;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompetitionEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        private readonly ICompetitionScoreService _competitionScoreService;
        private readonly ICompetitionApplicationService _competitionApplicationService;
        private readonly ICompetitionService _competitionService;
        private readonly IMapper _mapper;

        public ScoresController(
            ICompetitionScoreService competitionScoreService, 
            IMapper mapper,
            ICompetitionApplicationService competitionApplicationService,
            ICompetitionService competitionService)
        {
            _competitionScoreService = competitionScoreService;
            _competitionApplicationService = competitionApplicationService;
            _mapper = mapper;
            _competitionService = competitionService;
        }

        [HttpGet]
        public IEnumerable<CompetitionScoreViewModel> GetScores()
        {
            var competitionApplicationScores = _competitionScoreService.GetAll();

            return _mapper.Map<List<CompetitionScoreViewModel>>(competitionApplicationScores);
        }

        // GET: api/Contestants/5
        [HttpGet("{id}")]
        public IActionResult GetScore([FromRoute] int id)
        {
            var competitionApplication = _competitionApplicationService.GetById(id);

            if (competitionApplication == null)
            {
                return NotFound();
            }

            var competitionApplicationScores = _competitionScoreService.GetByCompetitionApplicationId(id);

            if(competitionApplicationScores == null)
            {
                return NotFound();
            }

            var competitionScoreViewModel = _mapper.Map<List<CompetitionScoreViewModel>>(competitionApplicationScores);

            ScoreViewModel model = new ScoreViewModel
            {
                CompetitionScores = competitionScoreViewModel,
                MainCompetitionId = competitionApplication.Competition.Id
            };

            return Ok(model);
        }

        [HttpPost]
        public IActionResult PostCompetitionScore([FromBody] ScoreSaveViewModel scoreSaveViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CompetitionScore competitionScore = null;

            if (_competitionScoreService.CheckIfExists(scoreSaveViewModel.CompetitionId,scoreSaveViewModel.CompetitionApplicationId))
            {
                var compAppScores = _competitionScoreService.GetByCompetitionApplicationId(scoreSaveViewModel.CompetitionApplicationId);

                competitionScore = compAppScores.FirstOrDefault(x => x.Competition.Id == scoreSaveViewModel.CompetitionId);

                competitionScore.FinalScore = scoreSaveViewModel.Score;
            }
            else
            {
                competitionScore = new CompetitionScore
                {
                    CompetitionApplication = _competitionApplicationService.GetById(scoreSaveViewModel.CompetitionApplicationId),
                    Competition = _competitionService.GetById(scoreSaveViewModel.CompetitionId),
                    FinalScore = scoreSaveViewModel.Score,
                    Status = Status.Active
                };
            }

            _competitionScoreService.Save(competitionScore);

            return Ok();
        }
    }
}