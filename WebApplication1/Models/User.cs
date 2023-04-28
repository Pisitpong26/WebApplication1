using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
