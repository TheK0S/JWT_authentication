using System.ComponentModel.DataAnnotations;

namespace JWT_authentication.Models
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "The name must be less than 20 characters long")]
        [MinLength(3, ErrorMessage = "The name must be more than 3 characters long")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "The password must be more than 8 characters long")]
        public string Password { get; set; }
    }
}
