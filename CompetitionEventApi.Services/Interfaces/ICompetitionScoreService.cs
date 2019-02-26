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
        List<CompetitionScore> GetByCompetitionApplicationId(int competitionApplicationId);
        bool CheckIfExists(int competitionId, int competitionApplicationId);
        bool Save(CompetitionScore post);
    }
}
