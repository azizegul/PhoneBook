using Microsoft.AspNetCore.Mvc;
using PhoneBook.Contact.Application.Person.Commands;
using PhoneBook.Contact.Application.Person.Commands.DeletePerson;
using PhoneBook.Contact.Application.Person.Queries.GetPersonQuery;
using PhoneBook.Contact.Application.Person.Queries.GetPersonsQuery;

namespace PhoneBook.Contact.Api.Controllers;

public class PersonController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreatePersonCommand command)
    {
        return await Mediator.Send(command);
    }
    
    [HttpGet]
    public async Task<ActionResult<List<GetPersonsDto>>> Get()
    {
        return await Mediator.Send(new GetPersonsQuery());
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<GetPersonDto>> GetPerson()
    {
        return await Mediator.Send(new GetPersonQuery());
    }

    
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        await Mediator.Send(new DeletePersonCommand(id));

        return NoContent();
    }
}