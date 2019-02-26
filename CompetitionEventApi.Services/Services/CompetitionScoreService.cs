using CompetitionEventApi.Services.DataObjects;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Services
{
    public class CompetitionScoreService : ICompetitionScoreService
    {
        CompetitionApiDbContext _context;

        public CompetitionScoreService(CompetitionApiDbContext competitionApiDbContext)
        {
            _context = competitionApiDbContext;
        }

        public List<CompetitionScore> GetAll()
        {
            return _context.CompetitionScore
                    .Include(x=>x.Competition)
                    .Include(x => x.CompetitionApplication)
                    .Include(x => x.CompetitionApplication.Contestant)
                    .ToList();
        }

        public List<CompetitionScore> GetByCompetitionApplicationId(int competitionApplicationId)
        {
            return _context.CompetitionScore
                    .Where(x=> x.CompetitionApplication.Id == competitionApplicationId)
                    .Include(y=> y.Competition)
                    .ToList();
        }

        public CompetitionScore GetById(int id)
        {
            return _context.CompetitionScore.FirstOrDefault(x => x.Id == id);
        }

        public bool CheckIfExists(int competitionId, int competitionApplicationId)
        {
            var score = _context.CompetitionScore.Where(x => x.Competition.Id == competitionId && x.CompetitionApplication.Id == competitionApplicationId);

            if(score != null)
            {
                return score?.Count() > 0;
            }

            return false;
        }

        public bool Save(CompetitionScore competitionScore)
        {
            if (competitionScore.Id > 0)
            {
                competitionScore.DateModified = DateTime.Now;
                _context.Entry(competitionScore).State = EntityState.Modified;
            }
            else
            {
                competitionScore.Status = Status.Active;
                competitionScore.DateCreated = DateTime.Now;
                competitionScore.DateModified = DateTime.Now;

                _context.CompetitionScore.Add(competitionScore);
            }

            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
    }
}
