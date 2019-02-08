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
    public class CompetitionService : ICompetitionService
    {
        CompetitionApiDbContext _context;

        public CompetitionService(CompetitionApiDbContext competitionApiDbContext)
        {
            _context = competitionApiDbContext;
        }

        public List<Competition> GetAll()
        {
            return _context.Competitions.ToList();
        }

        public Competition GetById(int id)
        {
            return _context.Competitions.FirstOrDefault(x => x.Id == id);
        }

        public bool Save(Competition competition)
        {
            if (competition.Id > 0)
            {
                competition.DateModified = DateTime.Now;
                _context.Entry(competition).State = EntityState.Modified;
            }
            else
            {
                competition.Status = Status.Active;
                competition.DateCreated = DateTime.Now;
                competition.DateModified = DateTime.Now;

                _context.Competitions.Add(competition);
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
