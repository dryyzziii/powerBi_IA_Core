namespace powerBi_IA_Core.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }  // Admin, Utilisateur, etc.
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User(int userID, string firstName, string lastName, string email, string passwordHash, string role)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void ChangeRole(string newRole)
        {
            Role = newRole;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
