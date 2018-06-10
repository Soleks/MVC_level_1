using System.ComponentModel.DataAnnotations;

namespace WebStore.Dto.Account
{
    public class LoginModel
    {
        [Required,MaxLength(256)]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
