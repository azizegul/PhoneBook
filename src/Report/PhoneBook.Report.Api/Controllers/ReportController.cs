using Microsoft.AspNetCore.Mvc;
using PhoneBook.Report.Application.Report.Command.CreateReport;

namespace PhoneBook.Report.Api.Controllers;

public class ReportController : ApiControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<ActionResult<string>> Create()
    {
        return await Mediator.Send(new CreateReportCommand());
    }
}