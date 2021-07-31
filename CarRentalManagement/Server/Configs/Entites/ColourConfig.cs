using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configs.Entites
{
    public class ColourConfig : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Black",
                    UpdateBy = "System"
                },
                new Colour
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Blue",
                    UpdateBy = "System"
                }
            );
        }
    }
}