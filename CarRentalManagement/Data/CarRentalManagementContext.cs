using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Data;
using CarRentalManagement.Configurations.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext(DbContextOptions<CarRentalManagementContext> options) : IdentityDbContext<CarRentalManagementUser>(options)
    {
        public DbSet<CarRentalManagement.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Vehicle> Vehicle { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ColourSeed());
            modelBuilder.ApplyConfiguration(new MakeSeed());
            modelBuilder.ApplyConfiguration(new ModeSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
        }
    }
}
