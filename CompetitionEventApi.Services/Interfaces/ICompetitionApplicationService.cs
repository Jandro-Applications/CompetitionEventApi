using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Interfaces
{
    public interface ICompetitionApplicationService
    {
        List<CompetitionApplication> GetAll();
        CompetitionApplication GetById(int id);
        bool Save(CompetitionApplication post);
        bool Done(int id);
    }
}
