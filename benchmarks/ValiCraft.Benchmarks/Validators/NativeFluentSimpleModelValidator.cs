using Native.FluentValidation.Builders;
using Native.FluentValidation.Core;
using ValiCraft.Benchmarks.Models;

namespace ValiCraft.Benchmarks.Validators;

public class NativeFluentSimpleModelValidator : NativeValidator<SimpleModel>
{
    public NativeFluentSimpleModelValidator()
    {
        RuleFor(x => x.Name, nameof(SimpleModel.Name))
            .NotEmpty()
            .Length(2, 100);

        RuleFor(x => x.Age, nameof(SimpleModel.Age))
            .When(x => x.Age >= 0 && x.Age <= 150);

        RuleFor(x => x.Email, nameof(SimpleModel.Email))
            .NotEmpty()!
            .Email();
    }
}
