using CompetitionEventApi.Services.DataObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services
{
    public class CompetitionApiDbCOntext : DbContext
    {
        public CompetitionApiDbCOntext(DbContextOptions<CompetitionApiDbCOntext> options) : base(options) { }

        public DbSet<CompetitionApplication> CompetitionApplication { get; set; }
        public DbSet<CompetitionEvent> CompetitionEvents { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Contestants> Contestants { get; set; }
    }
}
