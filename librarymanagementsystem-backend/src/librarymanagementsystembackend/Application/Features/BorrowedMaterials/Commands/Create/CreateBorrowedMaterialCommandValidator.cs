using FluentValidation;

namespace Application.Features.BorrowedMaterials.Commands.Create;

public class CreateBorrowedMaterialCommandValidator : AbstractValidator<CreateBorrowedMaterialCommand>
{
    public CreateBorrowedMaterialCommandValidator()
    {
        RuleFor(c => c.BorrowedDate).NotEmpty();
        RuleFor(c => c.ReturnDate).NotEmpty();
        RuleFor(c => c.IsReturned).NotEmpty();
        RuleFor(c => c.MemberId).NotEmpty();
        RuleFor(c => c.MaterialCopyId).NotEmpty();
    }
}