using FluentValidation;

namespace Application.Features.Neighborhoods.Commands.Create;

public class CreateNeighborhoodCommandValidator : AbstractValidator<CreateNeighborhoodCommand>
{
    public CreateNeighborhoodCommandValidator()
    {
        RuleFor(c => c.NeighborhoodName).NotEmpty();
        RuleFor(c => c.DistrictId).NotEmpty();
    }
}