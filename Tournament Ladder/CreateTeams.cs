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

namespace Tournament_Ladder
{
    public partial class CreateTeams : Form, ILadderRequester
    {
        Tree ladder = new();
        public CreateTeams()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates dummy teams
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTeamsButton_Click(object sender, EventArgs e)
        { 
            double Log2NumberOfTeams = Math.Log2((double)createTeamsNumeric.Value);

            if (Log2NumberOfTeams % 1 == 0 && createTeamsNumeric.Value > 1)
            {
                ladder = new();
                ladder = TeamCreation.CreateMatchups((int)createTeamsNumeric.Value);
                TournamentBrackets frm = new TournamentBrackets(this);
                frm.ShowDialog();
                this.Close();
                
            }
            else
                MessageBox.Show("Enter a valid number of teams log2n");  
        }
        /// <summary>
        /// Passes the ladder to the TournamentBrackets Form
        /// </summary>
        /// <returns></returns>
        Tree ILadderRequester.LadderCompletedLadder()
        {
            return ladder;
        }
    }
}
