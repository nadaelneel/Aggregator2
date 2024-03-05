using FluentValidation;

using User.Application.Feature.Command.Post;

namespace User.Application.Feature.Command.Validator
{
    public class AddUserValidator : AbstractValidator<PostUserCommand>
    {
        public AddUserValidator() { }

        public void ApplyValidatorRules()
        {
            RuleFor(i => i.Name)
                .NotEmpty().WithMessage("Name Required")
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(5);
        }
    }
}
