namespace Tournament_Ladder
{
    partial class CreateTeams
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
            this.createTeamsLabel = new System.Windows.Forms.Label();
            this.createTeamsNumeric = new System.Windows.Forms.NumericUpDown();
            this.createTeamsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.createTeamsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // createTeamsLabel
            // 
            this.createTeamsLabel.AutoSize = true;
            this.createTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamsLabel.Location = new System.Drawing.Point(42, 40);
            this.createTeamsLabel.Name = "createTeamsLabel";
            this.createTeamsLabel.Size = new System.Drawing.Size(102, 21);
            this.createTeamsLabel.TabIndex = 0;
            this.createTeamsLabel.Text = "Create Teams";
            // 
            // createTeamsNumeric
            // 
            this.createTeamsNumeric.Location = new System.Drawing.Point(150, 43);
            this.createTeamsNumeric.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.createTeamsNumeric.Name = "createTeamsNumeric";
            this.createTeamsNumeric.Size = new System.Drawing.Size(60, 23);
            this.createTeamsNumeric.TabIndex = 1;
            // 
            // createTeamsButton
            // 
            this.createTeamsButton.Location = new System.Drawing.Point(77, 82);
            this.createTeamsButton.Name = "createTeamsButton";
            this.createTeamsButton.Size = new System.Drawing.Size(102, 48);
            this.createTeamsButton.TabIndex = 2;
            this.createTeamsButton.Text = "Create";
            this.createTeamsButton.UseVisualStyleBackColor = true;
            this.createTeamsButton.Click += new System.EventHandler(this.createTeamsButton_Click);
            // 
            // CreateTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 181);
            this.Controls.Add(this.createTeamsButton);
            this.Controls.Add(this.createTeamsNumeric);
            this.Controls.Add(this.createTeamsLabel);
            this.Name = "CreateTeams";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.createTeamsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createTeamsLabel;
        private NumericUpDown createTeamsNumeric;
        private Button createTeamsButton;
    }
}