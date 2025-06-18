using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShrimpPond.Application.Features.Alarm.Queries;

namespace ShrimpPond.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmController : Controller
    {
        private readonly IMediator _mediator;
        
        public AlarmController(IMediator mediator) { 
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult GetFarm(int alarmid) {
            var farms = _mediator.Send(new GetFarm(alarmid));
            if (farms == null)
            {
                return BadRequest();
            }
            return Ok(farms);
        }
    }
}
