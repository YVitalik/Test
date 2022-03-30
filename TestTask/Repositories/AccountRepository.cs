using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Account Add(Account model)
        {
            _context.Accounts.Add(model);
            _context.SaveChanges();

            return model;
        }

        public int DeleteById(int modelId)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountByName(string accountName)
        {
            return _context.Accounts.FirstOrDefault(x => x.Name == accountName);
        }

        public IEnumerable<Account> GetAll()
        {
            return _context.Accounts;
        }

        public Account GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(Account model)
        {
            _context.Accounts.Update(model);
            _context.SaveChanges();
            return model.Id;
        }
    }
}
