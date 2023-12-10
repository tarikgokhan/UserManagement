namespace UserManagement.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; } // Gerçek uygulamada şifreler hashlenmelidir
        public bool IsActive { get; set; }
    }
}
