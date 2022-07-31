using MediatR;
using PhoneBook.Report.Application.Common.Interfaces;
using PhoneBook.Report.Domain.Enums;

namespace PhoneBook.Report.Application.Report.Command.CreateReport;

public record CreateReportCommand : IRequest<string>
{
}

public class CreateReportCommandHandler : IRequestHandler<CreateReportCommand, string>
{
    private readonly IApplicationDbContext _context;


    public CreateReportCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<string> Handle(CreateReportCommand request, CancellationToken cancellationToken)
    {
        var entity = new Domain.Entities.Report
        {
            RequestDate = DateTime.Now,
            Status = ReportStatus.Preparing
        };
        
        await _context.Report.InsertOneAsync(entity, null, cancellationToken);
        return entity.Id;
    }
}