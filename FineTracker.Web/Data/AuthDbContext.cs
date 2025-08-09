using FineTracker.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FineTracker.Web.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var userId = Guid.NewGuid();
            var adminId = Guid.NewGuid();
            var superAdminId = Guid.NewGuid();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = userId.ToString(),
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new IdentityRole
                {
                    Id = adminId.ToString(),
                    Name = "Admin",
                    NormalizedName = "Admin",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new IdentityRole
                {
                    Id = superAdminId.ToString(),
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                );

            var superAdminUserId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<IdentityUser>();

            var superAdminUser = new IdentityUser
            {
                Id = superAdminUserId,
                UserName = "Dhruv",
                NormalizedUserName = "DHRUV",
                Email = "dhruv@finetracker.dev",
                NormalizedEmail = "DHRUV@FINETRACKER.DEV",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            superAdminUser.PasswordHash = hasher.HashPassword(superAdminUser, "Dhruv@123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = superAdminUserId,
                    RoleId = superAdminId.ToString()
                }
            );
        
    }

    }
}
