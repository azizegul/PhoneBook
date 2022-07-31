using MongoDB.Driver;
using PhoneBook.Report.Domain.Entities;

namespace PhoneBook.Report.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    IMongoCollection<Domain.Entities.Report> Report { get; set; }
    IMongoCollection<ReportData> ReportData { get; set; }
}