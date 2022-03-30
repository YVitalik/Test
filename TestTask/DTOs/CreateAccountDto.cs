using System.ComponentModel.DataAnnotations;

namespace TestTask.DTOs
{
    public class CreateAccountDto
    {
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
