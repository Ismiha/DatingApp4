using System.ComponentModel.DataAnnotations;

namespace Datingapp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8), MinLength(4, ErrorMessage = "Password must be between 4 to 8 characters")]
        public string Password { get; set; }
    }
}