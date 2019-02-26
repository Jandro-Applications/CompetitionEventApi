using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class CompetitionScore : BaseEntity
    {
        public decimal Round1 { get; set; }
        public decimal Round2 { get; set; }
        public decimal Round3 { get; set; }
        public decimal Round4 { get; set; }
        public decimal Round5 { get; set; }
        public decimal FinalScore { get; set; }

        public Competition Competition { get; set; }
        public CompetitionApplication CompetitionApplication { get; set; }
    }
}