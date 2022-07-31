using FluentValidation;
using PhoneBook.Contact.Application.Person.Commands;

public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
{
    public CreatePersonCommandValidator()
    {
        RuleFor(v => v.Name)
            .MaximumLength(50)
            .NotEmpty();

        RuleFor(v => v.Surname)
            .MaximumLength(50)
            .NotEmpty();

        RuleFor(v => v.Company)
            .MaximumLength(100)
            .NotEmpty();
    }
}