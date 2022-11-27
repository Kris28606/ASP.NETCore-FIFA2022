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
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork unit;

        public GroupService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public bool Create(GroupDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
