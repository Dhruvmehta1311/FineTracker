using FineTracker.Web.Data;
using FineTracker.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

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

        public async Task<FineModel> AddUserAsync(FineModel fineModel)
        {
            await _dbContext.Fines.AddAsync(fineModel);
            await _dbContext.SaveChangesAsync();
            return fineModel;
        }
    }
}
