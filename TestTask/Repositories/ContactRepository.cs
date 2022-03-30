using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Contact Add(Contact model)
        {
            _context.Contacts.Add(model);
            _context.SaveChanges();

            return model;
        }

        public int DeleteById(int modelId)
        {
            throw new NotImplementedException();
        }

        public Contact FindByEmail(string email)
        {
            return _context.Contacts.FirstOrDefault(x => x.Email == email);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _context.Contacts;
        }

        public Contact GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(Contact model)
        {
            _context.Update(model);
            _context.SaveChanges();

            return model.Id;
        }
    }
}
