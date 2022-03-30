using System.ComponentModel.DataAnnotations;

namespace TestTask.DTOs
{
    public class CreateRecordDto : CreateAccountDto
    {
        [Required]
        public string Description { get; set; }
    }
}
