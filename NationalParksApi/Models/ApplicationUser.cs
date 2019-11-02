using Microsoft.AspNetCore.Identity;
namespace NationalParksApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string Email { get; set; }
        public override string UserName { get; set; }
        public override string SecurityStamp { get; set; }
    }
}