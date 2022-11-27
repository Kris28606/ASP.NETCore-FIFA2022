using DataAccessLayer.Interfaces;
using Domain;
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
        public List<Team> GetAll()
        {
            return null;
        }
    }
}
