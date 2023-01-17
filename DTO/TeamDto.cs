using Domain;

namespace DTO
{
    public class TeamDto : MyDto
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
        public string Group { get; set; }
    }
}