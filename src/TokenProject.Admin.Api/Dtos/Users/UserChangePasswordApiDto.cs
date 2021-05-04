using System.ComponentModel.DataAnnotations;

namespace TokenProject.Admin.Api.Dtos.Users
{
    public class UserChangePasswordApiDto<TKey>
    {
        public TKey UserId { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}







