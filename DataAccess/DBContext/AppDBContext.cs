using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facebook>(entity =>
            {

            });

            modelBuilder.Entity<Content>(entity =>
            {

            });

            modelBuilder.Entity<Config>(entity =>
            {

            });
        }

        public virtual DbSet<Facebook> Facebooks { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
    }
}
