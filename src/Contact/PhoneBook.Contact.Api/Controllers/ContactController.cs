using Microsoft.AspNetCore.Mvc;
using PhoneBook.Contact.Application.Contact.Commands.CreateContact;
using PhoneBook.Contact.Application.Contact.Commands.DeleteContact;

namespace PhoneBook.Contact.Api.Controllers;

public class ContactController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreateContactCommand command)
    {
        return await Mediator.Send(command);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        await Mediator.Send(new DeleteContactCommand(id));

        return NoContent();
    }
}