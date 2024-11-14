using FluentValidation;

namespace Library.Models.FluentValidators
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Zorunlu Alan!").MaximumLength(15).WithMessage("Max 15 Karakter");

            When(x => x.Name == "Deneme", () =>
            {
                RuleFor(x => x.PageCount).Must(y => y == "İsim Deneme ise sayfa sayısı 50 olmalı.");
            });
            RuleFor(x => x.PageCount).Must(y => int.TryParse(y, out int value)).WithMessage("Lütfen sayfayı sayı ile ifade edin");
        }
    }
}
