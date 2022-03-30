using System.ComponentModel.DataAnnotations;

namespace TestTask.DTOs
{
    public class CreateContactDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
