using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public CompetitionAplicationsController(
            ICompetitionService competitionService,
            IMapper mapper,
            ICompetitionApplicationService competitionApplicationService,
            RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _mapper = mapper;
            _competitionService = competitionService;
            _competitionApplicationService = competitionApplicationService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<CompetitionApplicationViewModel> GetCompetitionApplications()
        {
            //// first we create Admin rool    
            //var role = new IdentityRole();
            //role.Name = "Style";
            //_roleManager.CreateAsync(role);

            ////Here we create a Admin super user who will maintain the website                   

            //var user = new IdentityUser();
            //user.UserName = "Style";
            //user.Email = "style_sudac1@amkbilogora.hr";

            //string userPWD = "styleamk!1";

            //IdentityResult chkUser = _userManager.CreateAsync(user, userPWD).Result;

            ////Add default User to Role Admin    
            //if (chkUser.Succeeded)
            //{
            //    var result1 = _userManager.AddToRoleAsync(user, "Style");
            //}

            var allCompetitions = _mapper.Map<List<CompetitionApplicationViewModel>>(_competitionApplicationService.GetAll());
            if (User.Identity.Name == "style_sudac1@amkbilogora.hr")
            {
                return allCompetitions.Where(x => x.Competition.Id == 1);
            }
            else
            {
                return allCompetitions;
            }
        }
    }
}