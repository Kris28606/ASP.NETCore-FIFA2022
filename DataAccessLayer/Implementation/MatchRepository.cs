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
    public class MatchRepository : IMatchRepository
    {
        private readonly FifaContext context;

        public MatchRepository(FifaContext context)
        {
            this.context = context;
        }

        public void Create(Match entity)
        {
            context.Matches.Add(entity);
        }

        public List<Match> GetAll()
        {
            return context.Matches.Include(m => m.Team1).Include(m => m.Team2).Include(m => m.Team2.Group).Include(m => m.Team1.Group).OrderByDescending(m => m.DateTime).ToList();
        }
    }
}
