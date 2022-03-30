using TestTask.Entities;
using TestTask.Interfaces;

namespace TestTask.Repositories
{
    public class IncidentRepository : IIncidentRepository
    {
        private readonly ApplicationDbContext _context;

        public IncidentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Incident Add(Incident model)
        {
            _context.Incidents.Add(model);
            _context.SaveChanges();

            return model;
        }

        public int DeleteById(int modelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Incident> GetAll()
        {
            return _context.Incidents;
        }

        public Incident GetByGuid(Guid guid)
        {
            return _context.Incidents.FirstOrDefault(x => x.IncidentName == guid);
        }

        public Incident GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(Incident model)
        {
            _context.Incidents.Update(model);
            _context.SaveChanges();

            return 0;
        }
    }
}
