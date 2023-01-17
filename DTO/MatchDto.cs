using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatchDto : MyDto
    {
        public int MatchId { get; set; }
        public TeamDto Team1 { get; set; }
        public TeamDto Team2 { get; set; }
        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }
        public DateTime DateTime { get; set; }
        public String Stadium { get; set; }
        public String Group { get; set; }
        public MatchStatus Status { get; set; }
    }
}
