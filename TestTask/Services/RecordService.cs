using TestTask.DTOs;
using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Services
{
    public class RecordService : IRecordService
    {
        private readonly IContactRepository _contactRepo;
        private readonly IAccountRepository _accountRepo;
        private readonly IIncidentRepository _incidentRepo;
        public RecordService(IAccountRepository accountRepo, IContactRepository contactRepo, IIncidentRepository incidentRepo)
        {
            _incidentRepo = incidentRepo;
            _contactRepo = contactRepo;
            _accountRepo = accountRepo;
        }
        
        public void AddNewRecord(CreateRecordDto newRecord)
        {
            var checkIfAccountExist = _accountRepo.GetAccountByName(newRecord.AccountName);

            if (checkIfAccountExist is null)
            {
                throw new ArgumentException("Account doesnt exist exception");
            }

            var contact = _contactRepo.FindByEmail(newRecord.Email);

            if (contact != null)
            {
                contact.FirstName = newRecord.FirstName;
                contact.LastName = newRecord.LastName;
                contact.Email = newRecord.Email;
                contact.Account = checkIfAccountExist;
                
                _contactRepo.Update(contact);
            }

            else
            {
                var newContact = new Contact
                {
                    FirstName = newRecord.FirstName,
                    LastName = newRecord.LastName,
                    Email = newRecord.Email,
                    Account = checkIfAccountExist
                };

                _contactRepo.Add(newContact);

                var incident = new Incident
                {
                    Description = newRecord.Description,
                };

                var addedIncident = _incidentRepo.Add(incident);

                checkIfAccountExist.Incident = addedIncident;

                _accountRepo.Update(checkIfAccountExist);
            }
        }
    }
}
