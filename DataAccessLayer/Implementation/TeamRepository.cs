using DataAccessLayer.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementation
{
    public class TeamRepository : ITeamRepository
    {
        private readonly FifaContext context;

        public TeamRepository(FifaContext context)
        {
            this.context = context;
        }

        public void Create(Team entity)
        {
            context.Teams.Add(entity);
        }

        public List<Team> GetAll()
        {
            return context.Teams.Include(t=> t.Group).ToList().OrderBy(t=>t.Name).ToList();
        }

        public List<Team> GetTeamsForGroup(int groupId)
        {
            return context.Teams.Where(t => t.GroupId == groupId).ToList();
        }

        public void Update(Team team)
        {
            Team t = context.Teams.SingleOrDefault(t => t.TeamId == team.TeamId);
            if(t!=null)
            {
                t.Lost = team.Lost;
                t.Won = team.Won;
                t.Drawn = team.Drawn;
                t.Points = team.Points;
                t.GoalDifference = team.GoalDifference;
                t.Played = team.Played;
                context.Teams.Update(t);
            }
            
        }
    }
}
