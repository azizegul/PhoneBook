using Microsoft.AspNetCore.Mvc;
using PhoneBook.Contact.Application.Contact.Commands.CreateContact;

namespace PhoneBook.Contact.Api.Controllers;

public class ContactController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreateContactCommand command)
    {
        return await Mediator.Send(command);
    }
}