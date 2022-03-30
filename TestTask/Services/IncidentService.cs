using TestTask.DTOs;
using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Services
{
    public class IncidentService : IIncidentService
    {
        private readonly IIncidentRepository _incidentRepo;
        private readonly IAccountRepository _accountRepo;

        public IncidentService(IIncidentRepository incidentRepo, IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
            _incidentRepo = incidentRepo;
        }
        public void AddIncident(CreateIncidentDto newIncident)
        {
            var account = _accountRepo.GetAccountByName(newIncident.AccountName);

            if (account == null)
            {
                throw new ArgumentNullException("Account doesnt exist");
            }
            
            var incident = new Incident
            {
                Description = newIncident.Description
            };

            var returnedIncident = _incidentRepo.Add(incident);

            account.Incident = returnedIncident;

            _accountRepo.Update(account);
        }

        public IEnumerable<Incident> GetIncidents()
        {
            return _incidentRepo.GetAll();
        }
    }
}
