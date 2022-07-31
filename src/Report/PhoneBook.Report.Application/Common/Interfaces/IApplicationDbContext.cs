using MongoDB.Driver;

namespace PhoneBook.Report.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    IMongoCollection<T> GetCollection<T>(string name);
}