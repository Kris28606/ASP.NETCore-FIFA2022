using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Group
    {
        public int GroupId { get; set; }
        public String Name { get; set; }
        public int Team1Id { get; set; }
        public Team Team1 { get; set; }
        public int Team2Id { get; set; }
        public Team Team2 { get; set; }
        public int Team3Id { get; set; }
        public Team Team3 { get; set; }
        public int Team4Id { get; set; }
        public Team Team4 { get; set; }
    }
}
