namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            headerLabel = new Label();
            loadExistingTournamentDropDwon = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 20F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(171, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(352, 46);
            headerLabel.TabIndex = 13;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDwon
            // 
            loadExistingTournamentDropDwon.Font = new Font("Segoe UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadExistingTournamentDropDwon.FormattingEnabled = true;
            loadExistingTournamentDropDwon.Location = new Point(155, 139);
            loadExistingTournamentDropDwon.Name = "loadExistingTournamentDropDwon";
            loadExistingTournamentDropDwon.Size = new Size(384, 39);
            loadExistingTournamentDropDwon.TabIndex = 18;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Light", 14F);
            loadExistingTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingTournamentLabel.Location = new Point(212, 90);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(270, 32);
            loadExistingTournamentLabel.TabIndex = 17;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(229, 196);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(236, 47);
            loadTournamentButton.TabIndex = 19;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(229, 270);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(236, 47);
            createTournamentButton.TabIndex = 31;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(620, 343);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDwon);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDwon;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}