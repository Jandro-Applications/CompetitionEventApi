using CompetitionEventApi.Services.DataObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services
{
    public class CompetitionApiDbContext : DbContext
    {
        public CompetitionApiDbContext(DbContextOptions<CompetitionApiDbContext> options) : base(options) { }

        public DbSet<CompetitionApplication> CompetitionApplication { get; set; }
        public DbSet<CompetitionEvent> CompetitionEvents { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<CompetitionScore> CompetitionScore { get; set; }
        public DbSet<RelatedEventCompetition> RelatedEventCompetition { get; set; }
    }
}