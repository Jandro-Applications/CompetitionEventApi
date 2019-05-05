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
    public class CompetitionApplicationService : ICompetitionApplicationService
    {
        private readonly CompetitionApiDbContext _context;


        public CompetitionApplicationService(CompetitionApiDbContext competitionApiDbContext)
        {
            _context = competitionApiDbContext;
        }

        public List<CompetitionApplication> GetAll()
        {
            return _context.CompetitionApplication.Include( x => x.Contestant).Include( y => y.Competition).ToList();
        }

        public CompetitionApplication GetById(int id)
        {
            return _context.CompetitionApplication
                            .Include(x => x.Contestant)
                            .Include(y => y.Competition)
                            .FirstOrDefault(x => x.Id == id);
        }

        public bool Save(CompetitionApplication competitionApplication)
        {
            if (competitionApplication.Id > 0)
            {
                competitionApplication.DateModified = DateTime.Now;
                _context.Entry(competitionApplication).State = EntityState.Modified;
            }
            else
            {
                competitionApplication.Status = Status.Active;
                competitionApplication.DateCreated = DateTime.Now;
                competitionApplication.DateModified = DateTime.Now;

                _context.CompetitionApplication.Add(competitionApplication);
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
