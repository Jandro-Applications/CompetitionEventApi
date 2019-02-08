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
    public class CompetitionEventService : ICompetitionEventService
    {
        CompetitionApiDbContext _context;

        public CompetitionEventService(CompetitionApiDbContext competitionApiDbContext)
        {
            _context = competitionApiDbContext;
        }

        public List<CompetitionEvent> GetAll()
        {
            return _context.CompetitionEvents.ToList();
        }

        public CompetitionEvent GetById(int id)
        {
            return _context.CompetitionEvents.Include(r => r.RelatedEventCompetitions).FirstOrDefault(x => x.Id == id);
        }

        public bool Save(CompetitionEvent competitionEvent)
        {
            if (competitionEvent.Id > 0)
            {
                competitionEvent.DateModified = DateTime.Now;
                _context.Entry(competitionEvent).State = EntityState.Modified;
            }
            else
            {
                competitionEvent.Status = Status.Active;
                competitionEvent.DateCreated = DateTime.Now;
                competitionEvent.DateModified = DateTime.Now;

                _context.CompetitionEvents.Add(competitionEvent);
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

        public bool SaveRelatedEventCompetition(RelatedEventCompetition relatedEventCompetition)
        {
            if (relatedEventCompetition.Id > 0)
            {
                relatedEventCompetition.DateModified = DateTime.Now;
                _context.Entry(relatedEventCompetition).State = EntityState.Modified;
            }
            else
            {
                relatedEventCompetition.Status = Status.Active;
                relatedEventCompetition.DateCreated = DateTime.Now;
                relatedEventCompetition.DateModified = DateTime.Now;

                _context.RelatedEventCompetition.Add(relatedEventCompetition);
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
