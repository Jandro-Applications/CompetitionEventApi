using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class Contestant : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string UniqueId { get; set; }
        public string ClubName { get; set; }

        public virtual ICollection<CompetitionApplication> CompetitionApplications { get; set; }
    }
}
