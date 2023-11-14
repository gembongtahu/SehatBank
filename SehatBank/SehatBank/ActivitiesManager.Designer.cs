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
            caloriesBurnedTextBox = new TextBox();
            activitiesTextBox = new TextBox();
            activitiesLabel = new Label();
            caloriesBurnedLabel = new Label();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            dayOneView = new DataGridView();
            dayTwoView = new DataGridView();
            dayThreeView = new DataGridView();
            dayFourView = new DataGridView();
            dayFiveView = new DataGridView();
            daySixView = new DataGridView();
            daySevenView = new DataGridView();
            mainMenuButton = new Button();
            managerLabel = new Label();
            inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dayOneView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayTwoView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayThreeView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayFourView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayFiveView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)daySixView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)daySevenView).BeginInit();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Controls.Add(caloriesBurnedTextBox);
            inputBox.Controls.Add(activitiesTextBox);
            inputBox.Controls.Add(activitiesLabel);
            inputBox.Controls.Add(caloriesBurnedLabel);
            inputBox.Controls.Add(deleteButton);
            inputBox.Controls.Add(editButton);
            inputBox.Controls.Add(addButton);
            inputBox.ForeColor = SystemColors.ButtonHighlight;
            inputBox.Location = new Point(408, 23);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(323, 90);
            inputBox.TabIndex = 27;
            inputBox.TabStop = false;
            inputBox.Text = "Input Here";
            // 
            // caloriesBurnedTextBox
            // 
            caloriesBurnedTextBox.Location = new Point(144, 49);
            caloriesBurnedTextBox.Name = "caloriesBurnedTextBox";
            caloriesBurnedTextBox.Size = new Size(100, 23);
            caloriesBurnedTextBox.TabIndex = 1;
            // 
            // activitiesTextBox
            // 
            activitiesTextBox.Location = new Point(144, 25);
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
            activitiesLabel.Location = new Point(17, 26);
            activitiesLabel.Name = "activitiesLabel";
            activitiesLabel.Size = new Size(121, 22);
            activitiesLabel.TabIndex = 6;
            activitiesLabel.Text = "Activities Name:";
            activitiesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // caloriesBurnedLabel
            // 
            caloriesBurnedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            caloriesBurnedLabel.AutoSize = true;
            caloriesBurnedLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            caloriesBurnedLabel.ForeColor = SystemColors.ButtonHighlight;
            caloriesBurnedLabel.Location = new Point(18, 50);
            caloriesBurnedLabel.Name = "caloriesBurnedLabel";
            caloriesBurnedLabel.Size = new Size(120, 22);
            caloriesBurnedLabel.TabIndex = 7;
            caloriesBurnedLabel.Text = "Calories Burned:";
            caloriesBurnedLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // 
            // dayOneView
            // 
            dayOneView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayOneView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayOneView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayOneView.Location = new Point(637, 136);
            dayOneView.Name = "dayOneView";
            dayOneView.RowTemplate.Height = 25;
            dayOneView.Size = new Size(94, 241);
            dayOneView.TabIndex = 25;
            // 
            // dayTwoView
            // 
            dayTwoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayTwoView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayTwoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayTwoView.Location = new Point(537, 136);
            dayTwoView.Name = "dayTwoView";
            dayTwoView.RowTemplate.Height = 25;
            dayTwoView.Size = new Size(94, 241);
            dayTwoView.TabIndex = 24;
            // 
            // dayThreeView
            // 
            dayThreeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayThreeView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayThreeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayThreeView.Location = new Point(437, 136);
            dayThreeView.Name = "dayThreeView";
            dayThreeView.RowTemplate.Height = 25;
            dayThreeView.Size = new Size(94, 241);
            dayThreeView.TabIndex = 23;
            // 
            // dayFourView
            // 
            dayFourView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dayFourView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayFourView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayFourView.Location = new Point(337, 136);
            dayFourView.Name = "dayFourView";
            dayFourView.RowTemplate.Height = 25;
            dayFourView.Size = new Size(94, 241);
            dayFourView.TabIndex = 22;
            // 
            // dayFiveView
            // 
            dayFiveView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayFiveView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayFiveView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayFiveView.Location = new Point(237, 136);
            dayFiveView.Name = "dayFiveView";
            dayFiveView.RowTemplate.Height = 25;
            dayFiveView.Size = new Size(94, 241);
            dayFiveView.TabIndex = 21;
            // 
            // daySixView
            // 
            daySixView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daySixView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            daySixView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daySixView.Location = new Point(137, 136);
            daySixView.Name = "daySixView";
            daySixView.RowTemplate.Height = 25;
            daySixView.Size = new Size(94, 241);
            daySixView.TabIndex = 20;
            // 
            // daySevenView
            // 
            daySevenView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daySevenView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            daySevenView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daySevenView.Location = new Point(37, 136);
            daySevenView.Name = "daySevenView";
            daySevenView.RowTemplate.Height = 25;
            daySevenView.Size = new Size(94, 241);
            daySevenView.TabIndex = 19;
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
            managerLabel.Location = new Point(31, 35);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(330, 55);
            managerLabel.TabIndex = 26;
            managerLabel.Text = "Activities Manager";
            managerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ActivitiesManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(inputBox);
            Controls.Add(dayOneView);
            Controls.Add(dayTwoView);
            Controls.Add(dayThreeView);
            Controls.Add(dayFourView);
            Controls.Add(dayFiveView);
            Controls.Add(daySixView);
            Controls.Add(daySevenView);
            Controls.Add(mainMenuButton);
            Controls.Add(managerLabel);
            Name = "ActivitiesManager";
            Text = "ActivitiesManager";
            Load += ActivitiesManager_Load;
            Resize += ActivitiesManager_Resize;
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dayOneView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayTwoView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayThreeView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayFourView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayFiveView).EndInit();
            ((System.ComponentModel.ISupportInitialize)daySixView).EndInit();
            ((System.ComponentModel.ISupportInitialize)daySevenView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox inputBox;
        private TextBox caloriesBurnedTextBox;
        private TextBox activitiesTextBox;
        private Label activitiesLabel;
        private Label caloriesBurnedLabel;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private DataGridView dayOneView;
        private DataGridView dayTwoView;
        private DataGridView dayThreeView;
        private DataGridView dayFourView;
        private DataGridView dayFiveView;
        private DataGridView daySixView;
        private DataGridView daySevenView;
        private Button mainMenuButton;
        private Label managerLabel;
    }
}