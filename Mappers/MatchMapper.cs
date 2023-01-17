using Domain;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public class MatchMapper : GenericMapper<MatchDto, Match>
    {
        private TeamMapper teamMapper;

        public MatchMapper()
        {
            teamMapper = new TeamMapper();
        }
        public MatchDto toDto(Match entity)
        {
            MatchDto dto = new MatchDto
            {
                DateTime = entity.DateTime,
                Stadium = entity.Stadium,
                MatchId = entity.MatchId,
                Team1Goals = entity.Team1Goals,
                Team2Goals = entity.Team2Goals
            };
            if(entity.Team1.Group!=null)
            {
                dto.Group = entity.Team1.Group.Name;
            }
            dto.Team1 = teamMapper.toDto(entity.Team1);
            dto.Team2 = teamMapper.toDto(entity.Team2);
            return dto;
        }

        public Match toEntity(MatchDto dto)
        {
            Match entity = new Match
            {
                DateTime = dto.DateTime,
                Stadium = dto.Stadium,
                MatchId = dto.MatchId,
                Team1Goals = dto.Team1Goals,
                Team2Goals = dto.Team2Goals,
            };
            entity.Team1 = teamMapper.toEntity(dto.Team1);
            entity.Team2 = teamMapper.toEntity(dto.Team2);
            return entity;
        }
    }
}
