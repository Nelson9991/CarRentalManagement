using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configs.Entites
{
    public class ModelConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "Prius",
                    UpdateBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                },
                new Model
                {
                    Id = 2,
                    Name = "Vitz",
                    UpdateBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                },
                new Model
                {
                    Id = 3,
                    Name = "3 Series",
                    UpdateBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                },
                new Model
                {
                    Id = 4,
                    Name = "X5",
                    UpdateBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}