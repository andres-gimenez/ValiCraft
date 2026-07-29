using Native.FluentValidation.Builders;
using Native.FluentValidation.Core;
using ValiCraft.Benchmarks.Models;

namespace ValiCraft.Benchmarks.Validators;

public class NativeFluentComplexModelValidator : NativeValidator<ComplexModel>
{
    public NativeFluentComplexModelValidator()
    {
        RuleFor(x => x.FirstName, nameof(ComplexModel.FirstName))
            .NotEmpty()
            .Length(2, 10);

        RuleFor(x => x.LastName, nameof(ComplexModel.LastName))
            .NotEmpty()
            .Length(2, 50);

        RuleFor(x => x.Email, nameof(ComplexModel.Email))
            .NotEmpty()!
            .Email();

        RuleFor(x => x.Age, nameof(ComplexModel.Age))
            .When(c => c.Age >= 18 && c.Age <= 120);

        RuleFor(x => x.Salary, nameof(ComplexModel.Salary))
            .When(c => c.Salary >= 0 && c.Salary <= 1000000m);

        RuleFor(x => x.PhoneNumber, nameof(ComplexModel.PhoneNumber))
            .NotEmpty()
            .Length(10, 15);

        RuleFor(x => x.Address, nameof(ComplexModel.Address))
            .NotEmpty()
            .Length(5, 200);

        RuleFor(x => x.City, nameof(ComplexModel.City))
            .NotEmpty()
            .Length(2, 100);

        RuleFor(x => x.PostalCode, nameof(ComplexModel.PostalCode))
            .NotEmpty()
            .Length(3, 10);

        RuleFor(x => x.Country, nameof(ComplexModel.Country))
            .NotEmpty()
            .Length(2, 100);
    }
}
