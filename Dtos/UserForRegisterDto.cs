using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Your passwords are weak. Use something greater than 7 characters.")]
        public string Password { get; set; }
    }
}