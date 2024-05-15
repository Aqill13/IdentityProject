using DTOLayer.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş qoyula bilməz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş qoyula bilməz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("İstifadəçi adı boş qoyula bilməz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş qoyula bilməz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrə boş qoyula bilməz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Təkrar şifrə boş qoyula bilməz");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Max. 20 hərf girə bilərsiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Min. 3 hərf girə bilərsiniz");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifrələr uyğun deyil");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Uyğun email girin");
        }
    }
}
