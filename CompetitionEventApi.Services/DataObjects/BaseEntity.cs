using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.DataObjects
{
    public class BaseEntity
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 99)]
        public Status Status { get; set; }

        [Column(Order = 99)]
        public DateTime DateCreated { get; set; }

        [Column(Order = 99)]
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
