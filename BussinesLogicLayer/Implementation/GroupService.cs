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
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork unit;
        private GroupMapper groupMapper;

        public GroupService(IUnitOfWork unit)
        {
            this.unit = unit;
            groupMapper = new GroupMapper();
        }

        public bool Create(GroupDto entity)
        {
            throw new NotImplementedException();
        }

        public List<GroupDto> GetAll()
        {
            List<Group> groups = unit.GroupRepository.GetAll();
            List<GroupDto> dto = new List<GroupDto>();
            groups.ForEach(g =>
            {
                dto.Add(groupMapper.toDto(g));
            });
            return dto;
        }
    }
}
