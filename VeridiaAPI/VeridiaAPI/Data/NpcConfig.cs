using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridiaAPI.Models;

namespace VeridiaAPI.Data
{
    public class NpcConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name)
                .IsRequired().HasMaxLength(25);
            entity.Property(p => p.Gender)
                .IsRequired().HasMaxLength(25);
            entity.Property(p => p.Race)
                .IsRequired().HasMaxLength(25);
            entity.HasData(
                new Person { Id = 1, Name = "Alianor", Gender = "Female", Race = "Human"  },
                new Person { Id = 2, Name = "Ashtyn Briarlore", Gender = "Female", Race = "Naina" }
                );
        }
    }
}
