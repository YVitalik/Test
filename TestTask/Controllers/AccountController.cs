using Microsoft.AspNetCore.Mvc;
using TestTask.DTOs;
using TestTask.Interfaces;

namespace TestTask.Controllers
{
    [Route("test/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        [HttpPost("create")]
        public IActionResult CreateAccount(CreateAccountDto newAccount)
        {
            try
            {
                _accountService.AddNewAccount(newAccount);
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
            return Ok(_accountService.GetAccounts());
        }
    }
}
