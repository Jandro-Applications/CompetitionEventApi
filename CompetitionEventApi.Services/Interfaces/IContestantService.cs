using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Interfaces
{
    public interface IContestantService
    {
        List<Contestant> GetAll();
        Contestant GetById(int id);
        bool Save(Contestant post);
    }
}