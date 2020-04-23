using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeridiaAPI.Models;

namespace VeridiaAPI.Data
{
    public class NpcConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.FirstName)
                .IsRequired().HasMaxLength(25);
            entity.Property(p => p.LastName)
                .IsRequired().HasMaxLength(25);
            entity.HasData(
                new Person { Id = 1, FirstName = "Alek", LastName = "Brown" },
                new Person { Id = 2, FirstName = "Shea", LastName = "Brown" }
                ); ;
        }
    }
}
