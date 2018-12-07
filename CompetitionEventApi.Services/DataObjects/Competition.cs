using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class Competition : BaseEntity
    {
        public int CompetitionEventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CompetitionApplication> CompetitionApplications { get; set; }
        public virtual CompetitionEvent CompetitionEvent { get; set; }
    }
}
