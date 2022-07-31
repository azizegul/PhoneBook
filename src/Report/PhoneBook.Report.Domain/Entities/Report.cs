using PhoneBook.Report.Domain.Common;
using PhoneBook.Report.Domain.Enums;

namespace PhoneBook.Report.Domain.Entities;

public class Report : BaseEntity
{
    public DateTime RequestDate { get; set; }
    public ReportStatus Status { get; set; }
    public ReportData? Data { get; set; }
}