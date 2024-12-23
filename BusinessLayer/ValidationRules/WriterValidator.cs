﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(p => p.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(p => p.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(p => p.WriterAbout).NotEmpty().WithMessage("Hakkımdayı boş geçemezsiniz");
            RuleFor(p => p.WriterSurname).MinimumLength(3).WithMessage("En az 3 karekter girişi yapın");
            RuleFor(p => p.WriterSurname).MaximumLength(20).WithMessage("Maksimum 20 karekter !");
            RuleFor(p => p.WriterTitle).MaximumLength(50).WithMessage("Maksimum 50 karekter !");

        }
    }
}