using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IMatchRepository MatchRepository { get; set; }
        public ITeamRepository TeamRepository { get; set; }
        public IGroupRepository GroupRepository { get; set; }
        public void Save();
    }
}
