using MediatR;
using PhoneBook.Report.Application.Common.Interfaces;
using PhoneBook.Report.Domain.Enums;

namespace PhoneBook.Report.Application.Report.Command.PrepareReport;

public record PrepareReportCommand : IRequest<Unit>
{
}

public class PrepareReportCommandHandler : IRequestHandler<PrepareReportCommand, Unit>
{
    private readonly IApplicationDbContext _context;

    public PrepareReportCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(PrepareReportCommand request, CancellationToken cancellationToken)
    {
       //FL URL ile Contact servise git dataları al
       // Mapping yap
       // Grouplayıp ihtitacın olan dataları cıkar.
       // RaporId'si ile raporu bulup datasını güncelle ve rapor statusunu hazıra çek.
 
        return Unit.Value;
    }
}