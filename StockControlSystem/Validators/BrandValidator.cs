using FluentValidation;
using StockControlSystem.Models;

namespace StockControlSystem.Validators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(i => i.Name)
                 .NotEmpty().WithMessage("Please enter the name.")
                 .NotNull().WithMessage("Please enter the name.");

            RuleFor(i => i.Id)
                .NotEmpty().WithMessage("Please enter the email.")
                .NotNull().WithMessage("Please enter the email.");

            RuleFor(i => i.Description)
                .NotEmpty().WithMessage("Please enter the password.")
                .NotNull().WithMessage("Please enter the password.");
        }
    }
}
