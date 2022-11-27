using DataAccessLayer.Implementation;
using DataAccessLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FifaContext context;

        public UnitOfWork(FifaContext context)
        {
            this.MatchRepository = new MatchRepository(context);
            this.TeamRepository = new TeamRepository(context);
            this.GroupRepository=new GroupRepository(context);
            this.context = context;
        }

        public IMatchRepository MatchRepository { get; set; }
        public ITeamRepository TeamRepository { get; set; }
        public IGroupRepository GroupRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
