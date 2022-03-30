using TestTask.DTOs;
using TestTask.Entities;

namespace TestTask.Interfaces
{
    public interface IAccountService
    {
        void AddNewAccount(CreateAccountDto newAccount);
        IEnumerable<Account> GetAccounts();
    }
}
