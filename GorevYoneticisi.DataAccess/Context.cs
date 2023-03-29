using GorevYoneticisi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Duration>().HasData(new Duration { DurationId = 1, Name = "Günlük" });
            modelBuilder.Entity<Duration>().HasData(new Duration { DurationId = 2, Name = "Haftalık" });
            modelBuilder.Entity<Duration>().HasData(new Duration { DurationId = 3, Name = "Aylık" });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Duration> Durations { get; set; }
    }
}
