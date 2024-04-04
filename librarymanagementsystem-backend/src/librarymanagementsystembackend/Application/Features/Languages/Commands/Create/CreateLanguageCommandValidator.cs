using FluentValidation;

namespace Application.Features.Languages.Commands.Create;

public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommand>
{
    public CreateLanguageCommandValidator()
    {
        RuleFor(c => c.LanguageName).NotEmpty().MinimumLength(2).MaximumLength(150);
    }
}