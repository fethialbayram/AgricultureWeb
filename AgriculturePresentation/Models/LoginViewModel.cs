using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz!")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Lütfen parola giriniz!")]
        public string? password { get; set; }
    }
}
