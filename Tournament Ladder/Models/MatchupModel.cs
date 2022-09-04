using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Ladder.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Teams playing in current matchup
        /// </summary>
        public List<TeamModel>? TeamsCompeting { get; set; }
        public TeamModel? Winner { get; set; } = null;
        public int Round { get; set; }
        public bool Active { get; set; }
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
