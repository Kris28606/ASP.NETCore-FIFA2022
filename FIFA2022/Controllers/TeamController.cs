using BussinesLogicLayer.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIFA2022.Controllers
{
    [Route("team/")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(teamService.GetAll());
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{groupId}")]
        public IActionResult GetAllForGroup([FromRoute(Name="groupId")] int groupId)
        {
            try
            {
                return Ok(teamService.GetTeamsForGroup(groupId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("new")]
        public IActionResult CreateNew([FromBody] TeamDto team)
        {
            bool result = teamService.Create(team);
            if(result)
            {
                return Ok();
            }
            return BadRequest("Ne moze da sacuva!");
        }
    }
}
