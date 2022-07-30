using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Contact.Application.Common.Interfaces;
using PhoneBook.Contact.Domain.Entities;

namespace PhoneBook.Contact.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; }
    public DbSet<Domain.Entities.Contact> Contacts { get; }
 
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}