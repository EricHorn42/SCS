﻿using FluentValidation;
using StockControlSystem.Models;

namespace StockControlSystem.Validators
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(i => i.Name)
                 .NotEmpty().WithMessage("Please enter the name.")
                 .NotNull().WithMessage("Please enter the name.");

            RuleFor(i => i.Category)
                .NotEmpty().WithMessage("Please enter the email.")
                .NotNull().WithMessage("Please enter the email.");

            RuleFor(i => i.Price)
                .NotEmpty().WithMessage("Please enter the password.")
                .NotNull().WithMessage("Please enter the password.");
        }
    }
}
