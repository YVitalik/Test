using Microsoft.AspNetCore.Mvc;
using TestTask.DTOs;
using TestTask.Interfaces;

namespace TestTask.Controllers
{
    [Route("test/incident")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly IIncidentService _incidentService;

        public IncidentController(IIncidentService incidentService)
        {
            _incidentService = incidentService;
        }
        [HttpPost("create")]
        public IActionResult CreateIncident(CreateIncidentDto newIncident)
        {
            try
            {
                _incidentService.AddIncident(newIncident);
                return Ok();
            }
            catch (ArgumentNullException ex)
            {
                return StatusCode(404, ex.Message);
            }
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_incidentService.GetIncidents());
        }
    }
}
