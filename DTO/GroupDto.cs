using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GroupDto : MyDto
    {
        public int GroupId { get; set; }
        public String Name { get; set; }
        public List<TeamDto> Teams{ get; set; }
    }
}
