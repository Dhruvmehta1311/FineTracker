namespace FineTracker.Web.Models.Domain
{
    public class FineModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public int UserId { get; set; }
        public UserModel User { get; set; }

        public string Reason { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public bool IsPaid { get; set; } = false;
    }
}
