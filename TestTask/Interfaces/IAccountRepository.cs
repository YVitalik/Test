using TestTask.Entities;

namespace TestTask.Interfaces
{
    public interface IAccountRepository : ICrud<Account> 
    {
        Account GetAccountByName(string accountName);
    }
}
