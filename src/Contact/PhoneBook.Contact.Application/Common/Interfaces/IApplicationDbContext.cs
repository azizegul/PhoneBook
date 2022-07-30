using Microsoft.EntityFrameworkCore;
using PhoneBook.Contact.Domain.Entities;
namespace PhoneBook.Contact.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Person> Persons { get; }

    DbSet<Domain.Entities.Contact> Contacts { get; }
}