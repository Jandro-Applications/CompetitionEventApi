using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Interfaces
{
    public interface ICompetitionService
    {
        List<Competition> GetAll();
        Competition GetById(int id);
        bool Save(Competition post);
    }
}
