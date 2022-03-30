using TestTask.Entities;

namespace TestTask.Interfaces
{
    public interface IIncidentRepository : ICrud<Incident>
    {
        Incident GetByGuid(Guid guid);
    }
}
