using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.DTOs;
using TestTask.Interfaces;

namespace TestTask.Controllers
{
    [Route("test/record")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRecordService _recordService;

        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }
        [HttpPost("create")]
        public IActionResult CreateRecord(CreateRecordDto newRecord)
        {
            try
            {
                _recordService.AddNewRecord(newRecord);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
    }
}
