using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class FifaContext : DbContext
    {
        //public FifaContext([NotNull]DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=FIFA2022-Final; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Group>();
            builder.Entity<Team>().HasOne(t=> t.Group).WithMany(g=> g.Teams);
            builder.Entity<Team>().Property(t => t.GroupId).IsRequired(required: false);

            builder.Entity<Match>().HasOne(m => m.Team1).WithMany(t => t.FirstTeams).HasForeignKey(m => m.Team1Id);
            builder.Entity<Match>().HasOne(m => m.Team2).WithMany(t => t.SecondTeams).HasForeignKey(m => m.Team2Id);

        }
    }
}