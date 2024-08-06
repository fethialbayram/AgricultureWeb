using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz!")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta giriniz!")]
        public string? mail { get; set; }

        [Required(ErrorMessage = "Lütfen parola giriniz!")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Lütfen parolayı tekrar giriniz!")]
        [Compare("password",ErrorMessage ="Parolalar aynı değil!")]
        public string? confirmPassword { get; set; }
    }
}
