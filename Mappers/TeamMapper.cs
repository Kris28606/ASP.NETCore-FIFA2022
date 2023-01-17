using Domain;
using DTO;

namespace Mappers
{
    public class TeamMapper : GenericMapper<TeamDto, Team>
    {

        public TeamDto toDto(Team entity)
        {
            TeamDto dto = new TeamDto
            {
                TeamId = entity.TeamId,
                Continent = entity.Continent,
                Drawn = entity.Drawn,
                Pass = entity.Pass,
                Won = entity.Won,
                Lost = entity.Lost,
                Flag = entity.Flag,
                GoalDifference = entity.GoalDifference,
                Name = entity.Name,
                Played = entity.Played,
                Points = entity.Points
            };
            if(entity.Group!=null)
            {
                dto.Group = entity.Group.Name;
            }
            return dto;
        }

        public Team toEntity(TeamDto dto)
        {
            Team t = new Team
            {
                TeamId = dto.TeamId,
                Continent = dto.Continent,
                Drawn = dto.Drawn,
                Pass = dto.Pass,
                Won = dto.Won,
                Lost = dto.Lost,
                Flag = dto.Flag,
                GoalDifference = dto.GoalDifference,
                Name = dto.Name,
                Played = dto.Played,
                Points = dto.Points
            };
            return t;
        }
    }
}