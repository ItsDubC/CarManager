using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CarManager.Business.BusinessRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.Make).NotEmpty().WithMessage("Please specify a make.");
            RuleFor(c => c.Model).NotEmpty().WithMessage("Please specify a model.");
            RuleFor(c => c.Year).NotEmpty().WithMessage("Please specify a year.").Must(IsCarYearNotInTheFuture);
        }

        private bool IsCarYearNotInTheFuture(DateTime carYear)
        {
            return DateTime.Compare(DateTime.Now.AddYears(1), carYear) >= 0;
        }
    }
}