namespace BootcampApplication.model
{

    //verificar se iremos colocar mais campos de dados do usuario no formulario de inscricao.
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } 
        public RoleType Role { get; set; }
    }

    public enum RoleType
    {
        Candidate,
        Analyst,
        Admin
    }
}