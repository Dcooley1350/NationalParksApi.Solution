using System.ComponentModel.DataAnnotations;

namespace NationalParksApi.ViewModels

{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}