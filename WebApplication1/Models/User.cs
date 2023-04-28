using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
