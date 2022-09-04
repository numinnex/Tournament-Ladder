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

        private void LoadMatchupsByRounds()
        {
            selectedMatchups.Clear();
            int round = (int)roundsComboBox.SelectedItem;
            foreach (var mu in Matchups)
            {

                if (mu != null)
                {
                    if (mu.TeamsCompeting.First().Round == round)
                    {
                        selectedMatchups.Add(mu);
                    }
                }
            }
        }
        private void WireUpRoundsDropdown()
        {
            roundsComboBox.DataSource = TournamentLogic.Rounds;

        }
        private void WireUpMatchupBox()
        {
            MatchupsListBox.DataSource = null;
            MatchupsListBox.DataSource = selectedMatchups;
            MatchupsListBox.DisplayMember = "DisplayName";
        }
        private void WireUpTeamsBox()
        {
            displayTeamsBox.DataSource = null;
            displayTeamsBox.DataSource = TournamentLogic.Teams.Where(x => x.Name != null).ToList().OrderByDescending(x => x.Name).Reverse().ToList();
            displayTeamsBox.DisplayMember = "Name";
        }

        private void roundsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupsByRounds();
            WireUpMatchupBox();
        }
        /// <summary>
        /// Marks team one as winner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamOneWinnerButton_Click(object sender, EventArgs e)
        {
            MarkTeamAsWinner(0);
            WireUpTeamsBox();
        }
        /// <summary>
        /// Marks team two as winner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamTwoWinnerButton_Click(object sender, EventArgs e)
        {
            MarkTeamAsWinner(1);
            WireUpTeamsBox();

        }
        private void MarkTeamAsWinner(int team)
        {

            MatchupModel mu = MatchupsListBox.SelectedItem as MatchupModel;
            if (mu != null)
                mu.TeamsCompeting[team].Winner = true;

            if (mu != null)
            {
                if (mu.TeamsCompeting.First().Round == TournamentLogic.Rounds.Count)
                    MessageBox.Show($"Congratulations to {mu.TeamsCompeting.Where(x => x.Winner == true).ToList().First().Name} for winning");

                TournamentLogic.UpdateMatchups(TournamentLadder);
                LoadMatchupsByRounds();
                WireUpMatchupBox();
            }

        }


    }
}
