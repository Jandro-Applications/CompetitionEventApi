using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionEventApi.Models
{
    public class ScoreViewModel
    {
        public List<CompetitionScoreViewModel> CompetitionScores { get; set; }
        public int MainCompetitionId { get; set; }
        public string MainCompetitionName { get; set; }
    }

    public class ScoreSaveViewModel
    {
        public int CompetitionId { get; set; }
        public int CompetitionApplicationId { get; set; }
        public decimal Score{ get; set; }
    }
}
