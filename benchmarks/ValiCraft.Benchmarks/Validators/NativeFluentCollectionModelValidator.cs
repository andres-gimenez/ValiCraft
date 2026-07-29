using Native.FluentValidation.Core;
using ValiCraft.Benchmarks.Models;

namespace ValiCraft.Benchmarks.Validators;

public class NativeFluentCollectionModelValidator : NativeValidator<CollectionModel>
{
    public NativeFluentCollectionModelValidator()
    {
        RuleFor(x => x.Name, nameof(CollectionModel.Name))
            .NotEmpty()
            .Length(2, 100);

        RuleFor(x => x.Tags, nameof(CollectionModel.Tags))
            .Must(tags => tags.Count >= 1)
            .WithMessage("Tags must have a minimum count of 1")
            .Must(tags => tags.Count <= 10)
            .WithMessage("Tags must have a maximum count of 10");

        RuleFor(x => x.Scores, nameof(CollectionModel.Scores))
            .Must(scores => scores.Count >= 1)
            .WithMessage("Scores must have a minimum count of 1")
            .Must(scores => scores.Count <= 100)
            .WithMessage("Scores must have a maximum count of 100");
    }
}
