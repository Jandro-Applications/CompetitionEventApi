using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Interfaces
{
    public interface ICompetitionScoreService
    {
        List<CompetitionScore> GetAll();
        CompetitionScore GetById(int id);
        bool Save(CompetitionScore post);
    }
}
