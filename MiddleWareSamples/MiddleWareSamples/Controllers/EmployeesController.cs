using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleWareSamples.ActionFilters;

namespace MiddleWareSamples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ServiceFilter(typeof(WrapResponseFilter))]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees(int id)
        {
            return Ok(new { Id = id, Name = "Vikash Verma", Role = "Software Engineer" });
        }
         [HttpGet("bad")]
        public IActionResult GetError(int id)
        {
            return BadRequest("invalid Request");
        }
    }
}
