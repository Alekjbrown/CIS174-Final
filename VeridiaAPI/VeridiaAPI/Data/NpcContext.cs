using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeridiaAPI.Data;
using VeridiaAPI.Models;

namespace VeridiaAPI
{
    public class NpcContext : DbContext
    {
        public NpcContext(DbContextOptions<NpcContext> options)
            : base(options)
        {
        }

        //entities
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //TODO configures the DbContext
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NpcConfig());
        }
    }
}
