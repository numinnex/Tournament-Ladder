using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Ladder.Interfaces;

namespace Tournament_Ladder.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Id of matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Teams playing in current matchup
        /// </summary>
        public List<ITeam>? TeamsCompeting { get; set; }
        /// <summary>
        /// Winner of matchup
        /// </summary>
        public ITeam? Winner { get; set; } = null;
        /// <summary>
        /// Round of matchup
        /// </summary>
        public int Round { get; set; }
        /// <summary>
        /// Is the matchup completed
        /// </summary>
        public bool Completed { get; set; } = false;

        public string DisplayName
        {
            get
            {
                string output = "";

                if(TeamsCompeting.Count == 0)
                {
                    output = "TBD";
                    output += $" Round - {Round} muId {Id}";
                }
                if(TeamsCompeting.Count == 1)
                {
                    output = TeamsCompeting[0].Name;
                    output += " vs TBD";
                    output += $" Round - {Round} muID {Id}";

                }
                else
                {
                    foreach (var tm in TeamsCompeting)
                    {
                        if (tm.Name != null)
                        {
                            if (output.Length == 0)
                            {
                                output = tm.Name;
                                output += " vs";
                            }
                            else
                            {
                                output += $" {tm.Name}";
                                output += $" Round - {Round} muID {Id}";
                            }
                        }
                    }
                }
                return output;
            }

        }
    }
}
