using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configs.Entites
{
    public class MakeConfig : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "Toyota",
                    UpdateBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                },
                new Make
                {
                    Id = 2,
                    Name = "Renault",
                    UpdateBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}