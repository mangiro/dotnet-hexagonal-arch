using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class User
    {
        public User(string name, string email, DateTime timestamp)
        {
            Name = name;
            Email = email;
            Timestamp = timestamp;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }

        [MaxLength(16, ErrorMessage = "Name maximum length must be 16 characters")]
        public string Name { get; private set; }

        [EmailAddress(ErrorMessage = "Email must be in a valid email format")]
        public string Email { get; private set; }

        public DateTime Timestamp { get; private set; }
    }
}
