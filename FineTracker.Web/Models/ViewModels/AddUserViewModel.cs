namespace FineTracker.Web.Models.ViewModels
{
    public class AddUserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;
    }
}
