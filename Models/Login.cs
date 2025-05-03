using System.ComponentModel.DataAnnotations;

namespace CentralizedDatabaseManagementSystem.Models
{
    public class Login
    {
        public int id { get; set; }

        [Required]
        public int Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
