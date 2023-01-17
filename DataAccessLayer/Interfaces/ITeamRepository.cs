using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ITeamRepository : IRepository<Team>
    {
        public List<Team> GetTeamsForGroup(int groupId);
        public void Update(Team team);
    }
}
