using Microsoft.AspNetCore.Mvc.Rendering;

namespace FineTracker.Web.Models.ViewModels
{
    public class AddFineViewModel
    {
        public string UserName { get; set; }
        public decimal Amount { get; set; } = 10;
        public string Reason { get; set; } = "Came Late";
        public int UserId { get; set; }
        public bool IsPaid { get; set; }
        public List<SelectListItem> Users { get; set; }
    }
}
