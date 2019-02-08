using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionEventApi.Models
{
    public class CompetitionApplicationViewModel
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
        public CompetitionViewModel Competition { get; set; }
        public ContestantViewModel Contestant { get; set; }
    }
}
