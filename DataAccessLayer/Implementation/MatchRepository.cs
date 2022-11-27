using DataAccessLayer.Interfaces;
using Domain;
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
        public List<Match> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
