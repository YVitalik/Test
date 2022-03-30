using System.ComponentModel.DataAnnotations;

namespace TestTask.Entities
{
    public class Incident
    {
        [Key]
        public Guid IncidentName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
