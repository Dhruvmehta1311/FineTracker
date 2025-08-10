using FineTracker.Web.Data;
using FineTracker.Web.Models.ViewModels;
using FineTracker.Web.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FineTracker.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly AppDbContext _dbContext;
        public UserController(IUserRepository userRepository, AppDbContext dbContext)
        {
            _userRepository = userRepository;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult List()
        {
            var usersWithFines = _dbContext.Users
                     .Include(u => u.Fines)
                     .ToList();

            var totalFinePerUser = usersWithFines.Select(x => new UserFineViewModel
            {
                UserId = x.Id,
                UserName = x.UserName,
                TotalFine = x.TotalFine
            }).ToList();

            var viewModel = new UserListViewModel
            {
                UserFineViewModel = totalFinePerUser,
                AddUserViewModel = new AddUserViewModel()
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            return View();
        }
    }
}
