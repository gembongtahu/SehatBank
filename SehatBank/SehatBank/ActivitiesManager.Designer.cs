namespace SehatBank
{
    partial class ActivitiesManager
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
            inputBox = new GroupBox();
            activitiesTextBox = new TextBox();
            activitiesLabel = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            dataView = new DataGridView();
            mainMenuButton = new Button();
            managerLabel = new Label();
            dayOneButton = new Button();
            dayTwoButton = new Button();
            dayThreeButton = new Button();
            dayFourButton = new Button();
            dayFiveButton = new Button();
            daySixButton = new Button();
            daySevenButton = new Button();
            inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Controls.Add(activitiesTextBox);
            inputBox.Controls.Add(activitiesLabel);
            inputBox.Controls.Add(deleteButton);
            inputBox.Controls.Add(editButton);
            inputBox.Controls.Add(addButton);
            inputBox.ForeColor = SystemColors.ButtonHighlight;
            inputBox.Location = new Point(424, 24);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(323, 90);
            inputBox.TabIndex = 27;
            inputBox.TabStop = false;
            inputBox.Text = "Input Here";
            // 
            // activitiesTextBox
            // 
            activitiesTextBox.Location = new Point(149, 36);
            activitiesTextBox.Name = "activitiesTextBox";
            activitiesTextBox.Size = new Size(100, 23);
            activitiesTextBox.TabIndex = 0;
            // 
            // activitiesLabel
            // 
            activitiesLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            activitiesLabel.AutoSize = true;
            activitiesLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            activitiesLabel.ForeColor = SystemColors.ButtonHighlight;
            activitiesLabel.Location = new Point(22, 37);
            activitiesLabel.Name = "activitiesLabel";
            activitiesLabel.Size = new Size(121, 22);
            activitiesLabel.TabIndex = 6;
            activitiesLabel.Text = "Activities Name:";
            activitiesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.BackColor = Color.DimGray;
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(255, 67);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(50, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButton.BackColor = Color.DimGray;
            editButton.ForeColor = SystemColors.ButtonHighlight;
            editButton.Location = new Point(255, 35);
            editButton.Name = "editButton";
            editButton.Size = new Size(50, 23);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.BackColor = Color.DimGray;
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(255, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // dataView
            // 
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(153, 137);
            dataView.Name = "dataView";
            dataView.RowTemplate.Height = 25;
            dataView.Size = new Size(594, 241);
            dataView.TabIndex = 25;
            dataView.CellClick += dataView_CellClick;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackColor = Color.DimGray;
            mainMenuButton.ForeColor = SystemColors.ButtonHighlight;
            mainMenuButton.Location = new Point(663, 409);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(107, 23);
            mainMenuButton.TabIndex = 18;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = false;
            mainMenuButton.Click += mainMenuButton_Click_1;
            // 
            // managerLabel
            // 
            managerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managerLabel.AutoSize = true;
            managerLabel.Font = new Font("Heebo", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            managerLabel.ForeColor = SystemColors.ButtonHighlight;
            managerLabel.Location = new Point(47, 36);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(330, 55);
            managerLabel.TabIndex = 26;
            managerLabel.Text = "Activities Manager";
            managerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayOneButton
            // 
            dayOneButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayOneButton.BackColor = Color.DimGray;
            dayOneButton.ForeColor = SystemColors.ButtonHighlight;
            dayOneButton.Location = new Point(48, 158);
            dayOneButton.Name = "dayOneButton";
            dayOneButton.Size = new Size(99, 23);
            dayOneButton.TabIndex = 29;
            dayOneButton.Text = "Day One";
            dayOneButton.UseVisualStyleBackColor = false;
            dayOneButton.Click += dayOneButton_Click;
            // 
            // dayTwoButton
            // 
            dayTwoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayTwoButton.BackColor = Color.DimGray;
            dayTwoButton.ForeColor = SystemColors.ButtonHighlight;
            dayTwoButton.Location = new Point(48, 187);
            dayTwoButton.Name = "dayTwoButton";
            dayTwoButton.Size = new Size(99, 23);
            dayTwoButton.TabIndex = 30;
            dayTwoButton.Text = "Day Two";
            dayTwoButton.UseVisualStyleBackColor = false;
            dayTwoButton.Click += dayTwoButton_Click;
            // 
            // dayThreeButton
            // 
            dayThreeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayThreeButton.BackColor = Color.DimGray;
            dayThreeButton.ForeColor = SystemColors.ButtonHighlight;
            dayThreeButton.Location = new Point(48, 216);
            dayThreeButton.Name = "dayThreeButton";
            dayThreeButton.Size = new Size(99, 23);
            dayThreeButton.TabIndex = 31;
            dayThreeButton.Text = "Day Three";
            dayThreeButton.UseVisualStyleBackColor = false;
            dayThreeButton.Click += dayThreeButton_Click;
            // 
            // dayFourButton
            // 
            dayFourButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayFourButton.BackColor = Color.DimGray;
            dayFourButton.ForeColor = SystemColors.ButtonHighlight;
            dayFourButton.Location = new Point(48, 245);
            dayFourButton.Name = "dayFourButton";
            dayFourButton.Size = new Size(99, 23);
            dayFourButton.TabIndex = 32;
            dayFourButton.Text = "Day Four";
            dayFourButton.UseVisualStyleBackColor = false;
            dayFourButton.Click += dayFourButton_Click;
            // 
            // dayFiveButton
            // 
            dayFiveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayFiveButton.BackColor = Color.DimGray;
            dayFiveButton.ForeColor = SystemColors.ButtonHighlight;
            dayFiveButton.Location = new Point(48, 274);
            dayFiveButton.Name = "dayFiveButton";
            dayFiveButton.Size = new Size(99, 23);
            dayFiveButton.TabIndex = 33;
            dayFiveButton.Text = "Day Five";
            dayFiveButton.UseVisualStyleBackColor = false;
            dayFiveButton.Click += dayFiveButton_Click;
            // 
            // daySixButton
            // 
            daySixButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            daySixButton.BackColor = Color.DimGray;
            daySixButton.ForeColor = SystemColors.ButtonHighlight;
            daySixButton.Location = new Point(48, 303);
            daySixButton.Name = "daySixButton";
            daySixButton.Size = new Size(99, 23);
            daySixButton.TabIndex = 34;
            daySixButton.Text = "Day Six";
            daySixButton.UseVisualStyleBackColor = false;
            daySixButton.Click += daySixButton_Click;
            // 
            // daySevenButton
            // 
            daySevenButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            daySevenButton.BackColor = Color.DimGray;
            daySevenButton.ForeColor = SystemColors.ButtonHighlight;
            daySevenButton.Location = new Point(48, 332);
            daySevenButton.Name = "daySevenButton";
            daySevenButton.Size = new Size(99, 23);
            daySevenButton.TabIndex = 35;
            daySevenButton.Text = "Day Seven";
            daySevenButton.UseVisualStyleBackColor = false;
            daySevenButton.Click += daySevenButton_Click;
            // 
            // ActivitiesManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(daySevenButton);
            Controls.Add(daySixButton);
            Controls.Add(dayFiveButton);
            Controls.Add(dayFourButton);
            Controls.Add(dayThreeButton);
            Controls.Add(dayTwoButton);
            Controls.Add(dayOneButton);
            Controls.Add(inputBox);
            Controls.Add(dataView);
            Controls.Add(mainMenuButton);
            Controls.Add(managerLabel);
            Name = "ActivitiesManager";
            Text = "ActivitiesManager";
            Load += ActivitiesManager_Load;
            Resize += ActivitiesManager_Resize;
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox inputBox;
        private TextBox activitiesTextBox;
        private Label activitiesLabel;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private DataGridView dataView;
        private Button mainMenuButton;
        private Label managerLabel;
        private Button dayOneButton;
        private Button dayTwoButton;
        private Button dayThreeButton;
        private Button dayFourButton;
        private Button dayFiveButton;
        private Button daySixButton;
        private Button daySevenButton;
    }
}