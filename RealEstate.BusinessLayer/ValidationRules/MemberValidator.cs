using FluentValidation;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.ValidationRules
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.MemberNAme).NotEmpty().WithMessage("Lüften Ad Alanını Boş Geçmeyin!");
            RuleFor(x => x.MemberSurname).NotEmpty().WithMessage("Lütfen Soyad Alanını Boş Geçmeyin!");
            RuleFor(x => x.MemberSurname).MinimumLength(3).WithMessage("lütfen en az 3 karater veri girişi yapın!");
            RuleFor(x => x.MemberSurname).MaximumLength(20).WithMessage("lütfen en az 3 karater veri girişi yapın!");
        }
    }
}
