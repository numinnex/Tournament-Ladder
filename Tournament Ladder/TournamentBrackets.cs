using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Ladder.Interfaces;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{
    public partial class TournamentBrackets : Form
    {

        /// <summary>
        /// All global variables 
        /// </summary>
        private ILadderRequester _requester;
        private Tree TournamentLadder = new();
        private List<MatchupModel> Matchups = TournamentLogic.Matchups;
        private List<MatchupModel> selectedMatchups = new();

        public TournamentBrackets(ILadderRequester requester)
        {
            InitializeComponent();

            _requester = requester;
            TournamentLadder = _requester.LadderCompletedLadder();
            TournamentLogic.InitializeTournament(TournamentLadder);

             WireUpRoundsDropdown();
             LoadMatchupsByRounds();
             WireUpMatchupBox();
             WireUpTeamsBox();
        }

        /// <summary>
        /// Wire up the rounds dropdown (used to limit the matchups listbox)
        /// </summary>
        private void WireUpRoundsDropdown()
        {
            roundsComboBox.DataSource = TournamentLogic.Rounds;

        }

        /// <summary>
        /// Loads the matchups based on rounds
        /// </summary>
        private void LoadMatchupsByRounds()
        {
            selectedMatchups.Clear();
            int round = (int)roundsComboBox.SelectedItem;
            foreach (var mu in Matchups)
            {
                if (mu.Round == round)
                {
                    selectedMatchups.Add(mu);
                }
            }
        }
       
        /// <summary>
        /// Wire up the matchup box using methods from above
        /// </summary>
        private void WireUpMatchupBox()
        {
            MatchupsListBox.DataSource = null;
            MatchupsListBox.DataSource = selectedMatchups;
            MatchupsListBox.DisplayMember = "DisplayName";
        }
        /// <summary>
        /// Wire up team listbox based on the teams that are still competing in tournament
        /// </summary>
        private void WireUpTeamsBox()
        {
            displayTeamsBox.DataSource = null;
            displayTeamsBox.DataSource = TournamentLogic.Teams.OrderByDescending(x => x.Id).Reverse().ToList();
            displayTeamsBox.DisplayMember = "Name";
        }

        private void roundsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupsByRounds();
            WireUpMatchupBox();
        }
      
        /// <summary>
        /// Marks first team from the matchup as winner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamOneWinnerButton_Click(object sender, EventArgs e)
        {
            MarkTeamAsWinner(0);
            WireUpTeamsBox();
        }
        /// <summary>
        /// Marks second team from the matchup as winner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamTwoWinnerButton_Click(object sender, EventArgs e)
        {
            MarkTeamAsWinner(1);
            WireUpTeamsBox();

        }
        /// <summary>
        /// Implementation of method marking winning team
        /// </summary>
        /// <param name="team"></param>
        private void MarkTeamAsWinner(int team)
        {

            MatchupModel mu = MatchupsListBox.SelectedItem as MatchupModel;
            if (mu != null)
            {
                if (mu.TeamsCompeting.Count > 1)
                {
                    mu.Winner = mu.TeamsCompeting[team];
                    if (mu.Round == TournamentLogic.Rounds.Count)
                        MessageBox.Show($"Congratulations to {mu.Winner.Name} for winning");

                    TournamentLogic.UpdateMatchups(TournamentLadder);
                    LoadMatchupsByRounds();
                    WireUpMatchupBox();

                }
                else
                    MessageBox.Show("There are no teams to set the winner for");
            }
            else
                MessageBox.Show("There are no matchups to set winner for");
          

        }


    }
}
