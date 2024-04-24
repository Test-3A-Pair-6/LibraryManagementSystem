using FluentValidation;

namespace Application.Features.MaterialPropertyValues.Commands.Update;

public class UpdateMaterialPropertyValueCommandValidator : AbstractValidator<UpdateMaterialPropertyValueCommand>
{
    public UpdateMaterialPropertyValueCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Content).NotEmpty();
        RuleFor(c => c.MaterialId).NotEmpty();
        RuleFor(c => c.MaterialTypeId).NotEmpty();
        RuleFor(c => c.MaterialPropertyId).NotEmpty();
    }
}