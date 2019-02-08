using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class CompetitionApplication : BaseEntity
    {
        public Competition Competition { get; set; }
        public Contestant Contestant { get; set; }

        public virtual ICollection<CompetitionScore> CompetitionScores { get; set; }
    }
}
