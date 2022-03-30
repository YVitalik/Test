using TestTask.DTOs;
using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepo;
        public ContactService(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }
        public void AddContact(CreateContactDto newContact)
        {
            var check = _contactRepo.FindByEmail(newContact.Email);
            
            if (check != null)
            {
                throw new ArgumentException("Email is already taken please choose another");
            }

            var contact = new Contact
            {
                FirstName = newContact.FirstName,
                LastName = newContact.LastName,
                Email = newContact.Email
            };

            _contactRepo.Add(contact);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contactRepo.GetAll();
        }
    }
}
