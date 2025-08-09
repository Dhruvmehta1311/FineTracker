using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FineTracker.Web.Models.ViewModels.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("UserName")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
