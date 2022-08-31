using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Ladder.Models
{
    public class TeamModel
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? Winner { get; set; } = null;
        public int? Round { get; set; } = null;
        /// <summary>
        /// Stores the matchupId on teams individually so it can be passed back to the MatchupModel when AdvanceTeams method is called
        /// </summary>
        public int MatchupId { get; set; }


    }

}
