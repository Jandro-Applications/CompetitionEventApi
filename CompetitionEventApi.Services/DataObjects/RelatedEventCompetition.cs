using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class RelatedEventCompetition : BaseEntity
    {
        public CompetitionEvent CompetitionEvent { get; set; }
        public Competition Competition { get; set; }
    }
}
