using FluentValidation;

namespace Application.Features.MaterialCopies.Commands.Create;

public class CreateMaterialCopyCommandValidator : AbstractValidator<CreateMaterialCopyCommand>
{
    public CreateMaterialCopyCommandValidator()
    {
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.MaterialId).NotEmpty();
        RuleFor(c => c.BranchId).NotEmpty();
    }
}