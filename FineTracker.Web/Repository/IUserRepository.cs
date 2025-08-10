using FineTracker.Web.Models.Domain;
using FineTracker.Web.Models.ViewModels;

namespace FineTracker.Web.Repository
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUsersAsync();
        Task<FineModel> AddFineAsync(FineModel fineModel);
        Task<UserModel> GetTotalFineById(int userID);
        Task<UserModel> AddUserAsync(AddUserViewModel addUserViewModel);
    }
}
