using FineTracker.Web.Data;
using FineTracker.Web.Models.Domain;
using FineTracker.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FineTracker.Web.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            var allUsers = await _dbContext.Users.ToListAsync();

            return allUsers;
        }

        public async Task<FineModel> AddFineAsync(FineModel fineModel)
        {
            await _dbContext.Fines.AddAsync(fineModel);
            await _dbContext.SaveChangesAsync();
            return fineModel;
        }

        public async Task<UserModel> GetTotalFineById(int userID)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == userID);
            return user;
        }

        public async Task<UserModel> AddUserAsync(AddUserViewModel addUserViewModel)
        {
            var user = new UserModel
            {
                UserName = addUserViewModel.UserName,
                Email = addUserViewModel.Email
            };

            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

    }
}
