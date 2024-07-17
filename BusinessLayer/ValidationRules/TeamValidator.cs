using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x=>x.PersonName).NotEmpty().WithMessage("Ad Soyad kısmını boş geçemezsiniz!");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakter sınırını geçmeyiniz!");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla giriniz!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakter sınırını geçmeyiniz!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 5 karakterden daha fazla giriniz!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen fotoğraf ekleyiniz!");
            

        }                
    }
}
