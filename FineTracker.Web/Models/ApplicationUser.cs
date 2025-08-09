using Microsoft.AspNetCore.Identity;

namespace FineTracker.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
