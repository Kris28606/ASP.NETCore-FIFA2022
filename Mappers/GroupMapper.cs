using Domain;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public class GroupMapper : GenericMapper<GroupDto, Group>
    {
        private TeamMapper teamMapper;

        public GroupMapper()
        {
            teamMapper = new TeamMapper();
        }
        public GroupDto toDto(Group entity)
        {
            GroupDto dto = new GroupDto
            {
                GroupId = entity.GroupId,
                Name = entity.Name

            };
            dto.Teams = new List<TeamDto>();
            entity.Teams.ForEach(t =>
            {
                dto.Teams.Add(teamMapper.toDto(t));
            });
            return dto;
        }

        public Group toEntity(GroupDto dto)
        {
            Group e = new Group
            {
                GroupId = dto.GroupId,
                Name = dto.Name

            };
            e.Teams = new List<Team>();
            dto.Teams.ForEach(t =>
            {
                e.Teams.Add(teamMapper.toEntity(t));
            });
            return e;
        }
    }
}
