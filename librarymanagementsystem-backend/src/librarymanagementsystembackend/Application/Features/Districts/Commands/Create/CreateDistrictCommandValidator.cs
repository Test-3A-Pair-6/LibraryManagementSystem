using FluentValidation;

namespace Application.Features.Districts.Commands.Create;

public class CreateDistrictCommandValidator : AbstractValidator<CreateDistrictCommand>
{
    public CreateDistrictCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().Length(2, 150);
        RuleFor(c => c.CityId).NotEmpty();
    }
}