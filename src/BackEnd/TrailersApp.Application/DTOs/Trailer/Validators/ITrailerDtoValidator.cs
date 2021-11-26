using System;
using FluentValidation;

namespace TrailersApp.Application.DTOs.Trailer.Validators
{
    public class ITrailerDtoValidator : AbstractValidator<ITrailerDto>
    {
        public ITrailerDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("{PropertyName} is required.");

            RuleFor(x => x.ReleaseYear)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(4)
                .WithMessage("{PropertyName} must be less than 4 characters long.")
                .Must((data, token) =>
                {
                    var isValid = int.TryParse(data.ReleaseYear, out var value);
                    return isValid && value <= DateTime.Now.Year;
                })
                .WithMessage("{PropertyName} is invalid.");
            
            RuleFor(x => x.Duration)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(10)
                .WithMessage("{PropertyName} must be less than 10 characters long.");
            
            RuleFor(x => x.Catetgory)
                .NotNull().WithMessage("{PropertyName} is required.");
            
            RuleFor(x => x.Descrioption)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(250)
                .WithMessage("{PropertyName} must be less than 250 characters long.");
            
            RuleFor(x => x.Url)
                .NotNull().WithMessage("{PropertyName} is required.");
        }
    }
}