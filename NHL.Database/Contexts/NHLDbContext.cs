using Microsoft.EntityFrameworkCore;
using NHL.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Contexts
{
    public class NHLDbContext : DbContext
    {
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Team> Teams => Set<Team>();
        public DbSet<Season> Seasons => Set<Season>();
        public DbSet<PlayerTeam> PlayerTeams => Set<PlayerTeam>();
        public DbSet<PlayerStatistic> PlayerStatistics => Set<PlayerStatistic>();
        public DbSet<TeamStatistic> TeamStatistics => Set<TeamStatistic>();

        public NHLDbContext(DbContextOptions<NHLDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlayerTeam>().HasKey(ci => new { ci.PlayerId, ci.TeamId, ci.SeasonId });


            builder.Entity<PlayerTeam>()
                .HasKey(pt => new { pt.PlayerId, pt.TeamId, pt.SeasonId });

            builder.Entity<PlayerTeam>()
                .HasOne(pt => pt.Player)
                .WithMany(p => p.PlayerTeams)
                .HasForeignKey(pt => pt.PlayerId);

            builder.Entity<PlayerTeam>()
                .HasOne(pt => pt.Team)
                .WithMany(t => t.PlayerTeams)
                .HasForeignKey(pt => pt.TeamId);

            builder.Entity<PlayerTeam>()
                .HasOne(pt => pt.Season)
                .WithMany()
                .HasForeignKey(pt => pt.SeasonId);

            builder.Entity<PlayerStatistic>()
                .HasOne(ps => ps.Player)
                .WithMany(p => p.Statistics)
                .HasForeignKey(ps => ps.PlayerId);

            builder.Entity<PlayerStatistic>()
                .HasOne(ps => ps.Season)
                .WithMany()
                .HasForeignKey(ps => ps.SeasonId);

            builder.Entity<TeamStatistic>()
                .HasOne(ts => ts.Team)
                .WithMany(t => t.Statistics)
                .HasForeignKey(ts => ts.TeamId);

            base.OnModelCreating(builder);
        }
    }
}
