using TestTask.DTOs;
using TestTask.Entities;

namespace TestTask.Interfaces
{
    public interface IIncidentService
    {
        void AddIncident(CreateIncidentDto newIncident);
        IEnumerable<Incident> GetIncidents();
    }
}
