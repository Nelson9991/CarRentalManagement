using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configs.Entites
{
    public class UserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "356d96b5-dfa6-4ed5-a7b3-be95f68541a2",
                    UserId = "5c72668c-fac6-45dc-b5c7-9d8aef14a321"
                }
            );
        }
    }
}