using FluentValidation;

namespace AspDotnetCoreWorkshop.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Alanı boş geçilemez");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Price alanı boş geçilemez");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price alanı 0 dan büyük bir değer olmalıdır");

            RuleFor(x=>x.Quantity).NotEmpty().WithMessage("Quantity alanı boş geçilemez");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity alanı 0 dan büyük bir değer olmalıdır");
        }
    }
}
