using TestTask.DTOs;
using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepo;
        private readonly IContactRepository _contactRepo;

        public AccountService(IAccountRepository accountRepo, IContactRepository contactRepo)
        {
            _accountRepo = accountRepo;
            _contactRepo = contactRepo;
        }
        
        public void AddNewAccount(CreateAccountDto newAccount)
        {
            var check = _accountRepo.GetAccountByName(newAccount.AccountName);

            if (check != null)
            {
                throw new ArgumentException("Username already exists please choose other");
            }
            
            var account = new Account 
            {
                Name = newAccount.AccountName
            };

            var createdAccount = _accountRepo.Add(account);

            var contact = new Contact
            {
                FirstName = newAccount.FirstName,
                LastName = newAccount.LastName,
                Email = newAccount.Email,
                Account = createdAccount
            };

            _contactRepo.Add(contact);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepo.GetAll();
        }
    }
}
