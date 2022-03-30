using TestTask.DTOs;
using TestTask.Entities;

namespace TestTask.Interfaces
{
    public interface IContactService
    {
        void AddContact(CreateContactDto newContact);
        IEnumerable<Contact> GetContacts();
    }
}
