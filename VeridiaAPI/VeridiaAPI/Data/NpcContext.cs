using Microsoft.EntityFrameworkCore;
using System;
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
        public DbSet<Npc> npcs { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-81DVJ7L\\SQLEXPRESS;Initial Catalog=VeridiaAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"
        //, builder =>
        //    {
        //        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        //    });
            //Configures DbContext
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NpcConfig());
        }
    }
}
