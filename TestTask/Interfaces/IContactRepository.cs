using TestTask.Entities;

namespace TestTask.Interfaces
{
    public interface IContactRepository : ICrud<Contact>
    {
        Contact FindByEmail(string email);
    }
}
