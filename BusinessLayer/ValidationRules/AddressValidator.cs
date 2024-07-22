using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator :AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 boş geçilemez!");
            RuleFor(x => x.Description1).NotEmpty().MaximumLength(50).WithMessage("Lütfen 25 karakter sınırını geçmeyiniz!");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 boş geçilemez!");
            RuleFor(x => x.Description2).NotEmpty().MaximumLength(25).WithMessage("Lütfen 25 karakter sınırını geçmeyiniz!");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 boş geçilemez!");
            RuleFor(x => x.Description3).NotEmpty().MaximumLength(25).WithMessage("Lütfen 25 karakter sınırını geçmeyiniz!");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 boş geçilemez!");
            RuleFor(x => x.Description4).NotEmpty().MaximumLength(25).WithMessage("Lütfen 25 karakter sınırını geçmeyiniz!");
            RuleFor(x => x.Map).NotEmpty().WithMessage("Harita bilgisi boş geçilemez!");
        }

    }
}
