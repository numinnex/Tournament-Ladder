namespace Tournament_Ladder
{
    partial class TournamentBrackets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundsLabel = new System.Windows.Forms.Label();
            this.roundsComboBox = new System.Windows.Forms.ComboBox();
            this.matchupsLabel = new System.Windows.Forms.Label();
            this.MatchupsListBox = new System.Windows.Forms.ListBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.teamOneLabel = new System.Windows.Forms.Label();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.displayTeamsBox = new System.Windows.Forms.ListBox();
            this.teamOneWinnerButton = new System.Windows.Forms.Button();
            this.teamTwoWinnerButton = new System.Windows.Forms.Button();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundsLabel
            // 
            this.roundsLabel.AutoSize = true;
            this.roundsLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundsLabel.Location = new System.Drawing.Point(12, 41);
            this.roundsLabel.Name = "roundsLabel";
            this.roundsLabel.Size = new System.Drawing.Size(84, 30);
            this.roundsLabel.TabIndex = 0;
            this.roundsLabel.Text = "Rounds";
            // 
            // roundsComboBox
            // 
            this.roundsComboBox.FormattingEnabled = true;
            this.roundsComboBox.Location = new System.Drawing.Point(102, 48);
            this.roundsComboBox.Name = "roundsComboBox";
            this.roundsComboBox.Size = new System.Drawing.Size(47, 23);
            this.roundsComboBox.TabIndex = 1;
            this.roundsComboBox.SelectedIndexChanged += new System.EventHandler(this.roundsComboBox_SelectedIndexChanged);
            // 
            // matchupsLabel
            // 
            this.matchupsLabel.AutoSize = true;
            this.matchupsLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matchupsLabel.Location = new System.Drawing.Point(201, 41);
            this.matchupsLabel.Name = "matchupsLabel";
            this.matchupsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.matchupsLabel.Size = new System.Drawing.Size(107, 30);
            this.matchupsLabel.TabIndex = 2;
            this.matchupsLabel.Text = "Matchups";
            // 
            // MatchupsListBox
            // 
            this.MatchupsListBox.FormattingEnabled = true;
            this.MatchupsListBox.ItemHeight = 15;
            this.MatchupsListBox.Location = new System.Drawing.Point(314, 48);
            this.MatchupsListBox.Name = "MatchupsListBox";
            this.MatchupsListBox.Size = new System.Drawing.Size(320, 274);
            this.MatchupsListBox.TabIndex = 3;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(640, 39);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreLabel.Size = new System.Drawing.Size(126, 30);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score Team";
            // 
            // teamOneLabel
            // 
            this.teamOneLabel.AutoSize = true;
            this.teamOneLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneLabel.Location = new System.Drawing.Point(640, 80);
            this.teamOneLabel.Name = "teamOneLabel";
            this.teamOneLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.teamOneLabel.Size = new System.Drawing.Size(37, 30);
            this.teamOneLabel.TabIndex = 5;
            this.teamOneLabel.Text = "T1";
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoLabel.Location = new System.Drawing.Point(640, 121);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.teamTwoLabel.Size = new System.Drawing.Size(37, 30);
            this.teamTwoLabel.TabIndex = 6;
            this.teamTwoLabel.Text = "T2";
            // 
            // displayTeamsBox
            // 
            this.displayTeamsBox.FormattingEnabled = true;
            this.displayTeamsBox.ItemHeight = 15;
            this.displayTeamsBox.Location = new System.Drawing.Point(12, 111);
            this.displayTeamsBox.Name = "displayTeamsBox";
            this.displayTeamsBox.Size = new System.Drawing.Size(222, 199);
            this.displayTeamsBox.TabIndex = 9;
            // 
            // teamOneWinnerButton
            // 
            this.teamOneWinnerButton.Location = new System.Drawing.Point(674, 88);
            this.teamOneWinnerButton.Name = "teamOneWinnerButton";
            this.teamOneWinnerButton.Size = new System.Drawing.Size(75, 23);
            this.teamOneWinnerButton.TabIndex = 10;
            this.teamOneWinnerButton.Text = "Winner";
            this.teamOneWinnerButton.UseVisualStyleBackColor = true;
            this.teamOneWinnerButton.Click += new System.EventHandler(this.teamOneWinnerButton_Click);
            // 
            // teamTwoWinnerButton
            // 
            this.teamTwoWinnerButton.Location = new System.Drawing.Point(674, 128);
            this.teamTwoWinnerButton.Name = "teamTwoWinnerButton";
            this.teamTwoWinnerButton.Size = new System.Drawing.Size(75, 23);
            this.teamTwoWinnerButton.TabIndex = 11;
            this.teamTwoWinnerButton.Text = "Winner";
            this.teamTwoWinnerButton.UseVisualStyleBackColor = true;
            this.teamTwoWinnerButton.Click += new System.EventHandler(this.teamTwoWinnerButton_Click);
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamsLabel.Location = new System.Drawing.Point(12, 83);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(64, 25);
            this.teamsLabel.TabIndex = 12;
            this.teamsLabel.Text = "Teams";
            // 
            // TournamentBrackets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 444);
            this.Controls.Add(this.teamsLabel);
            this.Controls.Add(this.teamTwoWinnerButton);
            this.Controls.Add(this.teamOneWinnerButton);
            this.Controls.Add(this.displayTeamsBox);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.teamOneLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.MatchupsListBox);
            this.Controls.Add(this.matchupsLabel);
            this.Controls.Add(this.roundsComboBox);
            this.Controls.Add(this.roundsLabel);
            this.Name = "TournamentBrackets";
            this.Text = "TournamentBrackets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label roundsLabel;
        private ComboBox roundsComboBox;
        private Label matchupsLabel;
        private ListBox MatchupsListBox;
        private Label scoreLabel;
        private Label teamOneLabel;
        private Label teamTwoLabel;
        private ListBox displayTeamsBox;
        private Button teamOneWinnerButton;
        private Button teamTwoWinnerButton;
        private Label teamsLabel;
    }
}