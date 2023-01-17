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
    public class GroupRepository : IGroupRepository
    {
        private readonly FifaContext context;

        public GroupRepository(FifaContext context)
        {
            this.context = context;
        }

        public void Create(Group entity)
        {
            context.Add(entity);
        }

        public List<Group> GetAll()
        {
            return context.Groups.Include(g=> g.Teams).ToList();
        }
    }
}
