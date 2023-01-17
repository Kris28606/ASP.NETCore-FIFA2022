using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIFA2022.Controllers
{
    [Route("enum/")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        [HttpGet]
        [Route("continent")]
        public IActionResult GetAll()
        {
            try
            {
                Array niz=Enum.GetValues(typeof(Continent)); 
                return Ok(niz);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
