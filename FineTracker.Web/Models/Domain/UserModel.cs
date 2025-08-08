using System.IO;

namespace FineTracker.Web.Models.Domain
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }  
        public bool IsActive { get; set; } = true; 
        public DateTime DateJoined { get; set; } = DateTime.Now; 

        public int TotalFine { get; set; }

        // Navigation property
        public ICollection<FineModel> Fines { get; set; }
    }
}
