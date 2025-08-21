using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(template: "sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result  = a + b;
            return Ok(new{a,b,result});
        }
        [HttpGet(template: "resta")]
        public IActionResult GetResta([FromQuery] int a, [FromQuery] int b)
        {
            var result  = a - b;
            return Ok(new{a,b,result});
        }
        
        [HttpGet(template: "multi")]
        public IActionResult GetMulti([FromQuery] int a, [FromQuery] int b)
        {
            var result  = a * b;
            return Ok(new{a,b,result});
        }
        
        [HttpGet(template: "divid")]
        public IActionResult GetDivid([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
                return BadRequest(new { message = "b no puede " });
            var result  = a / b;
            return Ok(new{a,b,result});
        }
    }

}