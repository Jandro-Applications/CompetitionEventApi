using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class Competition : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfRounds { get; set; }
        public decimal MaxScore { get; set; }
        public int RelatedCompetitionId { get; set; }

        public virtual ICollection<RelatedEventCompetition> RelatedEventCompetitions { get; set; }
        public virtual ICollection<CompetitionApplication> CompetitionApplications { get; set; }
    }
}
