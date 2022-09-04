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
        public TeamModel? Winner { get; set; }
        public int Round { get; set; }

        public bool Active { get; set; }
        /// <summary>
        /// DisplayName property used by Teams ListBox in TournamentBrackets Form
        /// </summary>
        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (var tm in TeamsCompeting)
                {
                    if (tm.Name != null)
                    {
                        if (output.Length == 0)
                        {
                            output = tm.Name;
                        }
                        else
                        {
                            output += $" vs {tm.Name}";
                            //output += $" muId_ {Id}";
                        }
                    }
                    else
                    {
                        output = "TBD";
                        //output += $" muId_ {Id}";
                        break;
                    }

                }
                return output;

            }

        }
    }
}
