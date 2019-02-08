using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionEventApi.Models
{
    public class CompetitionScoreViewModel
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
        public decimal Round1 { get; set; }
        public decimal Round2 { get; set; }
        public decimal Round3 { get; set; }
        public decimal Round4 { get; set; }
        public decimal Round5 { get; set; }
        public decimal FinalScore { get; set; }
    }
}
