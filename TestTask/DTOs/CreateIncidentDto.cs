using System.ComponentModel.DataAnnotations;

namespace TestTask.DTOs
{
    public class CreateIncidentDto
    {
        [Required]
        public string AccountName { get; set; }
        public string Description { get; set; }
    }
}
