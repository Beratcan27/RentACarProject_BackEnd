using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.BrandId).NotEmpty();
            RuleFor(c=>c.ColorId).NotEmpty();
            RuleFor(c=>c.ModelName).NotEmpty().Length(2,50);
            RuleFor(c=>c.ModelYear).NotEmpty().GreaterThan(2000);
            RuleFor(c=>c.DailyPrice).NotEmpty();
            RuleFor(c=>c.Description).NotEmpty();
        }
    }
}
