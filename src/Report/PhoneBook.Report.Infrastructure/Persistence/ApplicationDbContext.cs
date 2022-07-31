using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PhoneBook.Report.Application.Common.Interfaces;
using PhoneBook.Report.Infrastructure.Persistence.Settings;

namespace PhoneBook.Report.Infrastructure.Persistence;

public class ApplicationDbContext : IApplicationDbContext
{
    private IMongoDatabase _db { get; set; }
    private MongoClient _mongoClient { get; set; }
    public IClientSessionHandle Session { get; set; }

    public ApplicationDbContext(IOptions<MongoDbSettings> configuration)
    {
        _mongoClient = new MongoClient(configuration.Value.Connection);
        _db = _mongoClient.GetDatabase(configuration.Value.DatabaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string name)
    {
        return _db.GetCollection<T>(name);
    }
}