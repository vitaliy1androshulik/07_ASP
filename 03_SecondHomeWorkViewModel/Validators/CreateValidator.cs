using _03_SecondHomeWorkViewModel.Entities;
using FluentValidation;

namespace _03_SecondHomeWorkViewModel.Validators
{
    public class CreateValidator:AbstractValidator<Mercedes>
    {
        public CreateValidator()
        {
            RuleFor(x=>x.Discount).NotEmpty().InclusiveBetween(0, 100);
            RuleFor(x=>x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x=>x.Discount).GreaterThanOrEqualTo(0);
            RuleFor(x=>x.Model).NotNull().NotEmpty();
            RuleFor(x => x.Class).NotNull().NotEmpty();
            RuleFor(x => x.BrandOfCarId).NotNull().GreaterThan(0).WithMessage("Brand is required");
            RuleFor(x => x.ImgUrl).Must(ValidateUri).WithMessage("Img URL must be a valid address");

        }
        public bool ValidateUri(string uri)
        {
            // just so the validation passes if the uri is not required / nullable
            if (string.IsNullOrEmpty(uri))
            {
                return true;
            }
            return Uri.TryCreate(uri, UriKind.Absolute, out _);
        }
    }
}
