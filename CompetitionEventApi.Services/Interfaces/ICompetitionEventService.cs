using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Interfaces
{
    public interface ICompetitionEventService
    {
        List<CompetitionEvent> GetAll();
        CompetitionEvent GetById(int id);
        bool Save(CompetitionEvent post);
        bool SaveRelatedEventCompetition(RelatedEventCompetition relatedEventCompetition);
    }
}
