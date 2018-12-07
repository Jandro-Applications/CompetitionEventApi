using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class CompetitionApplication : BaseEntity
    {
        public int CompetitionId { get; set; }
        public string RegistrationId { get; set; }
        public string Description { get; set; }
        
        public virtual Competition Competition { get; set; }
    }
}
