using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public enum MatchStatus
    {
        Completed,
        InProgress,
        NotPlayedYet
    }

    public class Match
    {
        public int MatchId { get; set; }
        public Team Team1 { get; set; }
        public int Team1Id { get; set; }
        public Team Team2 { get; set; }
        public int Team2Id { get; set; }
        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }
        public DateTime DateTime { get; set; }
        public MatchStatus Status { get; set; }

    }
}
