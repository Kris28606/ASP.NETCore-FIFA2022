using DataAccessLayer.Interfaces;
using Domain;
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
        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
