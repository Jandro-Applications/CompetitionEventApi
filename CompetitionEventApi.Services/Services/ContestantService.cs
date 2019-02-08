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
    public class ContestantService : IContestantService
    {
        CompetitionApiDbContext _context;

        public ContestantService(CompetitionApiDbContext competitionApiDbContext)
        {
            _context = competitionApiDbContext;
        }

        public List<Contestant> GetAll()
        {
            return _context.Contestants.ToList();
        }

        public Contestant GetById(int id)
        {
            return _context.Contestants.FirstOrDefault(x => x.Id == id);
        }

        public bool Save(Contestant contestant)
        {
            if (contestant.Id > 0)
            {
                contestant.DateModified = DateTime.Now;
                _context.Entry(contestant).State = EntityState.Modified;
            }
            else
            {
                contestant.Status = Status.Active;
                contestant.DateCreated = DateTime.Now;
                contestant.DateModified = DateTime.Now;

                _context.Contestants.Add(contestant);
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
