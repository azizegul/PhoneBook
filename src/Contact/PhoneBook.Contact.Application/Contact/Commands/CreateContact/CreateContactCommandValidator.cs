using FluentValidation;

namespace PhoneBook.Contact.Application.Contact.Commands.CreateContact;

public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
{
    public CreateContactCommandValidator()
    {
        RuleFor(v => v.PersonId)
            .NotEmpty();

        RuleFor(v => v.Info)
            .MaximumLength(100)
            .NotEmpty();

        RuleFor(v => v.InfoType)
            .NotEmpty();
    }
}