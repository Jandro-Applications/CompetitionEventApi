using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace CompetitionEventApi.Controllers
{
    [Authorize]
    public class AmkController : Controller
    {
        public AmkController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompetitionEvents()
        {
            return View();
        }

        public IActionResult CompetitionEvent(int id)
        {
            return View();
        }

        public IActionResult NewCompetitionEvent()
        {
            return View();
        }

        public IActionResult Competitions()
        {
            return View();
        }

        public IActionResult Competition(int id)
        {
            return View();
        }

        public IActionResult NewCompetition()
        {
            return View();

        }
        public IActionResult Contestants()
        {
            return View();
        }

        public IActionResult Contestant(int id)
        {
            return View();
        }

        public IActionResult NewContestant()
        {
            return View();
        }

        public IActionResult Posts()
        {
            return View();
        }

        public IActionResult Posts(int id)
        {
            return View();
        }

        public IActionResult Scoring()
        {
            return View();
        }

        public IActionResult Results()
        {
            return View();
        }

        public IActionResult Score(int id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
