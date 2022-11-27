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
    public class MatchService : IMatchService
    {

        private readonly IUnitOfWork unit;

        public MatchService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public bool Create(MatchDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
