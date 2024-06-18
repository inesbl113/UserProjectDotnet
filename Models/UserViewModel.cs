namespace Back.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserViewModel()
        {
            CreatedAt = DateTime.Now;
        }
    }
}