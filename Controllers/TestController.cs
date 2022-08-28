using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingMiddlewares.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("ex")]
        public ActionResult ex()
        {
            try
            {
                int n1 = 10;
                int n2 = 0;
                int result = n1/n2;
                return Ok(result);
            }
            catch (Exception e)
            { 
               return BadRequest("HATA ! "+e.Message);
            }
        }

        [HttpGet("ex2")]
        public ActionResult ex2()
        {
            int n1 = 10;
            int n2 = 0;
            int result = n1/n2;
            return Ok(result);
        }
    }
}
