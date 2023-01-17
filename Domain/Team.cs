using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain
{
    public enum Continent
    {
        Afrika,
        Evropa,
        Azija,
        Severna_Amerika,
        Juzna_Amerika,
        Okeanija,
        Australija
    }
    public class Team : MyEntity
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Drawn { get; set; }
        public int GoalDifference { get; set; }
        public bool Pass { get; set; }
        public int Points { get; set; }
        public string Flag { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        [JsonIgnore]
        public List<Match> FirstTeams { get; set; }
        [JsonIgnore]
        public List<Match> SecondTeams { get; set; }
    }
}
