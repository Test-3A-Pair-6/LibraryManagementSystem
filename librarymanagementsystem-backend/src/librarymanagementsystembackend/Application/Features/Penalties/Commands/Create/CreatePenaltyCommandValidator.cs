using FluentValidation;

namespace Application.Features.Penalties.Commands.Create;

public class CreatePenaltyCommandValidator : AbstractValidator<CreatePenaltyCommand>
{
    public CreatePenaltyCommandValidator()
    {
        RuleFor(c => c.TotalMaterialPenalty).NotEmpty();
        RuleFor(c => c.DayDelay).NotEmpty();
    }
}