namespace SehatBank
{
    partial class MainMenu
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
            label1 = new Label();
            quitButton = new Button();
            caloriesManagerButton = new Button();
            activitiesManagerButton = new Button();
            databaseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(239, 102);
            label1.Name = "label1";
            label1.Size = new Size(358, 94);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.DimGray;
            quitButton.ForeColor = SystemColors.ButtonHighlight;
            quitButton.Location = new Point(662, 375);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(75, 23);
            quitButton.TabIndex = 1;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // caloriesManagerButton
            // 
            caloriesManagerButton.BackColor = Color.DimGray;
            caloriesManagerButton.ForeColor = SystemColors.ButtonHighlight;
            caloriesManagerButton.Location = new Point(219, 211);
            caloriesManagerButton.Name = "caloriesManagerButton";
            caloriesManagerButton.Size = new Size(128, 23);
            caloriesManagerButton.TabIndex = 2;
            caloriesManagerButton.Text = "Calories Manager";
            caloriesManagerButton.UseVisualStyleBackColor = false;
            caloriesManagerButton.Click += caloriesManagerButton_Click;
            // 
            // activitiesManagerButton
            // 
            activitiesManagerButton.BackColor = Color.DimGray;
            activitiesManagerButton.ForeColor = SystemColors.ButtonHighlight;
            activitiesManagerButton.Location = new Point(353, 211);
            activitiesManagerButton.Name = "activitiesManagerButton";
            activitiesManagerButton.Size = new Size(128, 23);
            activitiesManagerButton.TabIndex = 3;
            activitiesManagerButton.Text = "Activities Manager";
            activitiesManagerButton.UseVisualStyleBackColor = false;
            activitiesManagerButton.Click += activitiesManagerButton_Click;
            // 
            // databaseButton
            // 
            databaseButton.BackColor = Color.DimGray;
            databaseButton.ForeColor = SystemColors.ButtonHighlight;
            databaseButton.Location = new Point(487, 211);
            databaseButton.Name = "databaseButton";
            databaseButton.Size = new Size(128, 23);
            databaseButton.TabIndex = 4;
            databaseButton.Text = "Database";
            databaseButton.UseVisualStyleBackColor = false;
            databaseButton.Click += databaseButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(databaseButton);
            Controls.Add(activitiesManagerButton);
            Controls.Add(caloriesManagerButton);
            Controls.Add(quitButton);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button quitButton;
        private Button caloriesManagerButton;
        private Button activitiesManagerButton;
        private Button databaseButton;
    }
}