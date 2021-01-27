using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyScoreboard
{
    [Serializable]
    public class Team
    {
        public string Name { get; set; }
        public string Score { get; set; }
        public string Set { get; set; }

        public Team()
        { }

        public Team(string name, string score, string set)
        {
            Name = name;
            Score = score;
            Set = set;
        }
    }
}
