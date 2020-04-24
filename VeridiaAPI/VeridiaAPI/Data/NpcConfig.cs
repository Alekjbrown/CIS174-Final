using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridiaAPI.Models;

namespace VeridiaAPI.Data
{
    public class NpcConfig : IEntityTypeConfiguration<Npc>
    {
        public void Configure(EntityTypeBuilder<Npc> entity)
        {
            entity.HasKey(n => n.Id);
            entity.Property(n => n.Name)
                .IsRequired().HasMaxLength(25);
            entity.Property(n => n.Gender)
                .IsRequired().HasMaxLength(25);
            entity.Property(n => n.Race)
                .IsRequired().HasMaxLength(25);
            entity.HasData(
                new Npc { Id = 1, Name = "Alianor", Gender = "Female", Race = "Human"  },
                new Npc { Id = 2, Name = "Ashtyn Briarlore", Gender = "Female", Race = "Naina" }
                );
        }
    }
}
