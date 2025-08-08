using FineTracker.Web.Models.Domain;

namespace FineTracker.Web.Repository
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUsersAsync();
        Task<FineModel> AddUserAsync(FineModel fineModel);
    }
}
