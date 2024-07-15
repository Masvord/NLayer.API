using FluentValidation;
using NLayerPractice.Core.DTOs;

namespace NLayerPractice.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        // Data Annotations with "FluentValidation" library.
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name can not be empty.");

            RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater than 0");
            RuleFor(x => x.Quantity).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater than 0");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater than 0");
        }
    }
}
