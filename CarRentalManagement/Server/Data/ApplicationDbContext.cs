using System;
using CarRentalManagement.Server.Configs.Entites;
using CarRentalManagement.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ColourConfig());
            builder.ApplyConfiguration(new MakeConfig());
            builder.ApplyConfiguration(new ModelConfig());
            builder.ApplyConfiguration(new RoleConfig());
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new UserRoleConfig());

            base.OnModelCreating(builder);
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
