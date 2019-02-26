using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompetitionEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionAplicationsController : ControllerBase
    {
        private readonly ICompetitionService _competitionService;
        private readonly IMapper _mapper;
        private readonly ICompetitionApplicationService _competitionApplicationService;


        public CompetitionAplicationsController(
            ICompetitionService competitionService,
            IMapper mapper,
            ICompetitionApplicationService competitionApplicationService)
        {
            _mapper = mapper;
            _competitionService = competitionService;
            _competitionApplicationService = competitionApplicationService;
        }

        [HttpGet]
        public IEnumerable<CompetitionApplicationViewModel> GetCompetitionApplications()
        {
            return _mapper.Map<List<CompetitionApplicationViewModel>>(_competitionApplicationService.GetAll());
        }
    }
}