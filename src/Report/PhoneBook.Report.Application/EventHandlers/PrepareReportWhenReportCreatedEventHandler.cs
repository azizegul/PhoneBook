using MassTransit;
using Microsoft.Extensions.Logging;
using PhoneBook.Report.Domain.Events;

namespace PhoneBook.Report.Application.EventHandlers;

public class PrepareReportWhenReportCreatedEventHandler : IConsumer<ReportCreated>
{
    private ILogger<PrepareReportWhenReportCreatedEventHandler> _logger;

    public PrepareReportWhenReportCreatedEventHandler(ILogger<PrepareReportWhenReportCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<ReportCreated> context)
    {
        _logger.LogWarning("I love u" + context.Message.Id);
        return Task.CompletedTask;
    }
}