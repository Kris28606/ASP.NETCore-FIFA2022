using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer.Interfaces
{
    public interface ITeamService : IService<TeamDto>
    {
        public List<TeamDto> GetTeamsForGroup(int groupId);
    }
}
