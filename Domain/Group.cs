using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Group : MyEntity
    {
        public int GroupId { get; set; }
        public String Name { get; set; }
        public List<Team> Teams { get; set; }
    }
}
