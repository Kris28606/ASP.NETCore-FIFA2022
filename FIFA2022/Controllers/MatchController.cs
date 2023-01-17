using BussinesLogicLayer.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIFA2022.Controllers
{
    [Route("match/")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService matchService)
        {
            this.matchService = matchService;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(matchService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("new")]
        public IActionResult CreateNew([FromBody] MatchDto match)
        {
            bool result = matchService.Create(match);
            if (result)
            {
                return Ok();
            }
            return BadRequest("Ne moze da sacuva!");
        }
    }
}
