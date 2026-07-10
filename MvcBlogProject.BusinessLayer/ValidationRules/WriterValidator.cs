using FluentValidation;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan Kısmını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapın!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen 20 Karakterden Fazla Karakter Girişi Yapmayın!");
        }
    }
}
