namespace BootcampApplication.model
{
    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public RoleType Role { get; set; }
    }

    public enum RoleType
    {
        Candidate,
        Analyst,
        Admin
    }
}