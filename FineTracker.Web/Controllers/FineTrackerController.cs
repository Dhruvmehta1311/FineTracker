using FineTracker.Web.Models.Domain;
using FineTracker.Web.Models.ViewModels;
using FineTracker.Web.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FineTracker.Web.Controllers
{
    [Authorize]
    public class FineTrackerController : Controller
    {
        private readonly IUserRepository _userRepository;
        public FineTrackerController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var allUsers = await _userRepository.GetAllUsersAsync();

            var model = new AddFineViewModel
            {
                Users = allUsers.Select(u => new SelectListItem
                {
                    Value = u.Id.ToString(),
                    Text = u.UserName,
                }).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddFineViewModel addFineModel)
        {

            var domainModel = new FineModel
            {
                Amount = addFineModel.Amount,
                UserId = addFineModel.UserId,
                Reason = addFineModel.Reason,
                IsPaid = addFineModel.IsPaid,
            };

            var addedUser = await _userRepository.AddUserAsync(domainModel);

            return RedirectToAction("List", "User");
        }
    }
}
