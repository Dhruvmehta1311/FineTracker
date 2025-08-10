using System.ComponentModel.DataAnnotations;

namespace FineTracker.Web.Models.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;
    }
}
