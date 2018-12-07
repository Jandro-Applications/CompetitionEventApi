using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }

    public enum Status
    {
        Active = 1,
        Inactive = 2,
        Finished = 3,
        Deleted = 4
    }
}
