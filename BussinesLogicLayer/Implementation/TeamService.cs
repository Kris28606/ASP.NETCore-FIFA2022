using BussinesLogicLayer.Interfaces;
using DataAccessLayer.UnitOfWork;
using Domain;
using DTO;
using Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer.Implementation
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork unit;
        private TeamMapper teamMapper;

        public TeamService(IUnitOfWork unit)
        {
            this.unit = unit;
            teamMapper = new TeamMapper();
        }
        public bool Create(TeamDto entity)
        {
            Team team=teamMapper.toEntity(entity);
            try
            {

                unit.TeamRepository.Create(team);
                unit.Save();
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }

        public List<TeamDto> GetAll()
        {
            List<Team> teams=unit.TeamRepository.GetAll();
            List<TeamDto> teamsDto = new List<TeamDto>();
            teams.ForEach(team =>
            {
                teamsDto.Add(teamMapper.toDto(team));
            });
            return teamsDto;
        }

        public List<TeamDto> GetTeamsForGroup(int groupId)
        {
            List<Team> teams = unit.TeamRepository.GetTeamsForGroup(groupId);
            List<TeamDto> teamsDto = new List<TeamDto>();
            teams.ForEach(team =>
            {
                teamsDto.Add(teamMapper.toDto(team));
            });
            return teamsDto;
        }
    }
}
