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
    public class MatchService : IMatchService
    {
        private MatchMapper matchMapper;

        private readonly IUnitOfWork unit;

        public MatchService(IUnitOfWork unit)
        {
            this.unit = unit;
            this.matchMapper = new MatchMapper();
        }

        public bool Create(MatchDto entity)
        {
            Match match = matchMapper.toEntity(entity);
            try
            {
                Team team1 = match.Team1;
                Team team2 = match.Team2;
                match.Team1 = null;
                match.Team1Id = entity.Team1.TeamId;
                match.Team2Id = entity.Team2.TeamId;
                match.Team2 = null;
                unit.MatchRepository.Create(match);

                if(match.Team1Goals>match.Team2Goals)
                {
                    team1.Won += 1;
                    team2.Lost += 1;
                    team1.GoalDifference += (match.Team1Goals - match.Team2Goals);
                    team2.GoalDifference -= (match.Team1Goals - match.Team2Goals);
                    team1.Points += 3;
                } else if(match.Team2Goals==match.Team1Goals)
                {
                    team1.Drawn += 1;
                    team2.Drawn += 1;
                    team1.Points += 1;
                    team2.Points += 1;
                } else
                {
                    team2.Won += 1;
                    team1.Lost += 1;
                    team2.GoalDifference += (match.Team2Goals - match.Team1Goals);
                    team1.GoalDifference -= (match.Team2Goals - match.Team1Goals);
                    team2.Points += 3;
                }
                team1.Played += 1;
                team2.Played += 1;
                unit.TeamRepository.Update(team1);
                unit.TeamRepository.Update(team2);
                unit.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<MatchDto> GetAll()
        {
            List<Match> matches = unit.MatchRepository.GetAll();
            List<MatchDto> dto = new List<MatchDto>();
            matches.ForEach(m =>
            {
                dto.Add(matchMapper.toDto(m));
            });
            return dto;
        }
    }
}
