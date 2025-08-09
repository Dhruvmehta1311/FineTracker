using FineTracker.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FineTracker.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<FineModel> Fines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().HasData(
                new UserModel { Id = 1, UserName = "Dhruv", Email = "dhruv.mehta@finova.tech", IsActive = true, DateJoined = DateTime.Now },
                new UserModel { Id = 2, UserName = "Dhairya", Email = "dhairya.sharma@finova.tech", IsActive = true, DateJoined = DateTime.Now },
                new UserModel { Id = 3, UserName = "Tarun", Email = "tarun.gautam@finova.tech", IsActive = true, DateJoined = DateTime.Now },
                new UserModel { Id = 4, UserName = "Mukul", Email = "mukul.kumar@finova.tech", IsActive = true, DateJoined = DateTime.Now },
                new UserModel { Id = 5, UserName = "Gaurav", Email = "gaurav.saini@finova.tech", IsActive = true, DateJoined = DateTime.Now },
                new UserModel { Id = 6, UserName = "Shrawan", Email = "shrawan.khatri@finova.tech", IsActive = true, DateJoined = DateTime.Now }

                );

        }

    }
}
