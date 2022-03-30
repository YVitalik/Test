using Microsoft.AspNetCore.Mvc;
using TestTask.DTOs;
using TestTask.Interfaces;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("test/contact")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        
        [HttpPost("create")]
        public IActionResult CreateContact(CreateContactDto newContact)
        {
            try
            {
                _contactService.AddContact(newContact);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return StatusCode(404, ex.Message);
            }
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_contactService.GetContacts());
        }
    }
}
