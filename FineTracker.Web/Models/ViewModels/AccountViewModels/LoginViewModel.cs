using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FineTracker.Web.Models.ViewModels.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
