using BussinesLogicLayer.Interfaces;
using DataAccessLayer.UnitOfWork;
using DTO;
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

        public TeamService(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public bool Create(TeamDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
