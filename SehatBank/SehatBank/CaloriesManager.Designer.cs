namespace SehatBank
{
    partial class CaloriesManager
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
            managerLabel = new Label();
            addButton = new Button();
            foodTextBox = new TextBox();
            foodLabel = new Label();
            editButton = new Button();
            deleteButton = new Button();
            mainMenuButton = new Button();
            inputBox = new GroupBox();
            daySevenButton = new Button();
            daySixButton = new Button();
            dayFiveButton = new Button();
            dayFourButton = new Button();
            dayThreeButton = new Button();
            dayTwoButton = new Button();
            dayOneButton = new Button();
            dataView = new DataGridView();
            inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // managerLabel
            // 
            managerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managerLabel.AutoSize = true;
            managerLabel.Font = new Font("Heebo", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            managerLabel.ForeColor = SystemColors.ButtonHighlight;
            managerLabel.Location = new Point(45, 21);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(314, 55);
            managerLabel.TabIndex = 13;
            managerLabel.Text = "Calories Manager";
            managerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.BackColor = Color.DimGray;
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(211, 9);
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // foodTextBox
            // 
            foodTextBox.Location = new Point(105, 38);
            foodTextBox.Name = "foodTextBox";
            foodTextBox.Size = new Size(100, 23);
            foodTextBox.TabIndex = 0;
            // 
            // foodLabel
            // 
            foodLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            foodLabel.AutoSize = true;
            foodLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            foodLabel.ForeColor = SystemColors.ButtonHighlight;
            foodLabel.Location = new Point(7, 38);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(92, 22);
            foodLabel.TabIndex = 6;
            foodLabel.Text = "Food Name:";
            foodLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButton.BackColor = Color.DimGray;
            editButton.ForeColor = SystemColors.ButtonHighlight;
            editButton.Location = new Point(211, 38);
            editButton.Name = "editButton";
            editButton.Size = new Size(50, 23);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.BackColor = Color.DimGray;
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(211, 67);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(50, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackColor = Color.DimGray;
            mainMenuButton.ForeColor = SystemColors.ButtonHighlight;
            mainMenuButton.Location = new Point(681, 403);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(107, 23);
            mainMenuButton.TabIndex = 5;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = false;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(foodTextBox);
            inputBox.Controls.Add(foodLabel);
            inputBox.Controls.Add(deleteButton);
            inputBox.Controls.Add(editButton);
            inputBox.Controls.Add(addButton);
            inputBox.ForeColor = SystemColors.ButtonHighlight;
            inputBox.Location = new Point(472, 4);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(273, 90);
            inputBox.TabIndex = 17;
            inputBox.TabStop = false;
            inputBox.Text = "Input Here";
            inputBox.Enter += inputBox_Enter;
            // 
            // daySevenButton
            // 
            daySevenButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            daySevenButton.BackColor = Color.DimGray;
            daySevenButton.ForeColor = SystemColors.ButtonHighlight;
            daySevenButton.Location = new Point(51, 300);
            daySevenButton.Name = "daySevenButton";
            daySevenButton.Size = new Size(99, 23);
            daySevenButton.TabIndex = 43;
            daySevenButton.Text = "Day Seven";
            daySevenButton.UseVisualStyleBackColor = false;
            daySevenButton.Click += daySevenButton_Click;
            // 
            // daySixButton
            // 
            daySixButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            daySixButton.BackColor = Color.DimGray;
            daySixButton.ForeColor = SystemColors.ButtonHighlight;
            daySixButton.Location = new Point(51, 271);
            daySixButton.Name = "daySixButton";
            daySixButton.Size = new Size(99, 23);
            daySixButton.TabIndex = 42;
            daySixButton.Text = "Day Six";
            daySixButton.UseVisualStyleBackColor = false;
            daySixButton.Click += daySixButton_Click;
            // 
            // dayFiveButton
            // 
            dayFiveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayFiveButton.BackColor = Color.DimGray;
            dayFiveButton.ForeColor = SystemColors.ButtonHighlight;
            dayFiveButton.Location = new Point(51, 242);
            dayFiveButton.Name = "dayFiveButton";
            dayFiveButton.Size = new Size(99, 23);
            dayFiveButton.TabIndex = 41;
            dayFiveButton.Text = "Day Five";
            dayFiveButton.UseVisualStyleBackColor = false;
            dayFiveButton.Click += dayFiveButton_Click;
            // 
            // dayFourButton
            // 
            dayFourButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayFourButton.BackColor = Color.DimGray;
            dayFourButton.ForeColor = SystemColors.ButtonHighlight;
            dayFourButton.Location = new Point(51, 213);
            dayFourButton.Name = "dayFourButton";
            dayFourButton.Size = new Size(99, 23);
            dayFourButton.TabIndex = 40;
            dayFourButton.Text = "Day Four";
            dayFourButton.UseVisualStyleBackColor = false;
            dayFourButton.Click += dayFourButton_Click;
            // 
            // dayThreeButton
            // 
            dayThreeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayThreeButton.BackColor = Color.DimGray;
            dayThreeButton.ForeColor = SystemColors.ButtonHighlight;
            dayThreeButton.Location = new Point(51, 184);
            dayThreeButton.Name = "dayThreeButton";
            dayThreeButton.Size = new Size(99, 23);
            dayThreeButton.TabIndex = 39;
            dayThreeButton.Text = "Day Three";
            dayThreeButton.UseVisualStyleBackColor = false;
            dayThreeButton.Click += dayThreeButton_Click;
            // 
            // dayTwoButton
            // 
            dayTwoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayTwoButton.BackColor = Color.DimGray;
            dayTwoButton.ForeColor = SystemColors.ButtonHighlight;
            dayTwoButton.Location = new Point(51, 155);
            dayTwoButton.Name = "dayTwoButton";
            dayTwoButton.Size = new Size(99, 23);
            dayTwoButton.TabIndex = 38;
            dayTwoButton.Text = "Day Two";
            dayTwoButton.UseVisualStyleBackColor = false;
            dayTwoButton.Click += dayTwoButton_Click;
            // 
            // dayOneButton
            // 
            dayOneButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dayOneButton.BackColor = Color.DimGray;
            dayOneButton.ForeColor = SystemColors.ButtonHighlight;
            dayOneButton.Location = new Point(51, 126);
            dayOneButton.Name = "dayOneButton";
            dayOneButton.Size = new Size(99, 23);
            dayOneButton.TabIndex = 37;
            dayOneButton.Text = "Day One";
            dayOneButton.UseVisualStyleBackColor = false;
            dayOneButton.Click += dayOneButton_Click;
            // 
            // dataView
            // 
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(156, 105);
            dataView.Name = "dataView";
            dataView.RowTemplate.Height = 25;
            dataView.Size = new Size(594, 241);
            dataView.TabIndex = 36;
            dataView.CellClick += dataView_CellClick;
            // 
            // CaloriesManager
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
            Controls.Add(dataView);
            Controls.Add(inputBox);
            Controls.Add(mainMenuButton);
            Controls.Add(managerLabel);
            Name = "CaloriesManager";
            Text = "CaloriesManager";
            Load += CaloriesManager_Load;
            Resize += CaloriesManager_Resize;
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label managerLabel;
        private Button addButton;
        private TextBox foodTextBox;
        private Label foodLabel;
        private Button editButton;
        private Button deleteButton;
        private Button mainMenuButton;
        private GroupBox inputBox;
        private Button daySevenButton;
        private Button daySixButton;
        private Button dayFiveButton;
        private Button dayFourButton;
        private Button dayThreeButton;
        private Button dayTwoButton;
        private Button dayOneButton;
        private DataGridView dataView;
    }
}