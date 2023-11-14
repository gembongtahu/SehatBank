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
            caloriesTextBox = new TextBox();
            foodLabel = new Label();
            caloriesLabel = new Label();
            editButton = new Button();
            deleteButton = new Button();
            daySevenView = new DataGridView();
            mainMenuButton = new Button();
            daySixView = new DataGridView();
            dayFiveView = new DataGridView();
            dayFourView = new DataGridView();
            dayThreeView = new DataGridView();
            dayTwoView = new DataGridView();
            dayOneView = new DataGridView();
            inputBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)daySevenView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)daySixView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayFiveView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayFourView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayThreeView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayTwoView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayOneView).BeginInit();
            inputBox.SuspendLayout();
            SuspendLayout();
            // 
            // managerLabel
            // 
            managerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managerLabel.AutoSize = true;
            managerLabel.Font = new Font("Heebo", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            managerLabel.ForeColor = SystemColors.ButtonHighlight;
            managerLabel.Location = new Point(49, 29);
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
            foodTextBox.Location = new Point(105, 25);
            foodTextBox.Name = "foodTextBox";
            foodTextBox.Size = new Size(100, 23);
            foodTextBox.TabIndex = 0;
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Location = new Point(105, 49);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new Size(100, 23);
            caloriesTextBox.TabIndex = 1;
            // 
            // foodLabel
            // 
            foodLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            foodLabel.AutoSize = true;
            foodLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            foodLabel.ForeColor = SystemColors.ButtonHighlight;
            foodLabel.Location = new Point(7, 25);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(92, 22);
            foodLabel.TabIndex = 6;
            foodLabel.Text = "Food Name:";
            foodLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // caloriesLabel
            // 
            caloriesLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            caloriesLabel.AutoSize = true;
            caloriesLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            caloriesLabel.ForeColor = SystemColors.ButtonHighlight;
            caloriesLabel.Location = new Point(29, 48);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(70, 22);
            caloriesLabel.TabIndex = 7;
            caloriesLabel.Text = "Calories:";
            caloriesLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // daySevenView
            // 
            daySevenView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daySevenView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            daySevenView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daySevenView.Location = new Point(55, 130);
            daySevenView.Name = "daySevenView";
            daySevenView.RowTemplate.Height = 25;
            daySevenView.Size = new Size(94, 241);
            daySevenView.TabIndex = 6;
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
            // daySixView
            // 
            daySixView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daySixView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            daySixView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daySixView.Location = new Point(155, 130);
            daySixView.Name = "daySixView";
            daySixView.RowTemplate.Height = 25;
            daySixView.Size = new Size(94, 241);
            daySixView.TabIndex = 7;
            // 
            // dayFiveView
            // 
            dayFiveView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayFiveView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayFiveView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayFiveView.Location = new Point(255, 130);
            dayFiveView.Name = "dayFiveView";
            dayFiveView.RowTemplate.Height = 25;
            dayFiveView.Size = new Size(94, 241);
            dayFiveView.TabIndex = 8;
            // 
            // dayFourView
            // 
            dayFourView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayFourView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayFourView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayFourView.Location = new Point(355, 130);
            dayFourView.Name = "dayFourView";
            dayFourView.RowTemplate.Height = 25;
            dayFourView.Size = new Size(94, 241);
            dayFourView.TabIndex = 9;
            // 
            // dayThreeView
            // 
            dayThreeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayThreeView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayThreeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayThreeView.Location = new Point(455, 130);
            dayThreeView.Name = "dayThreeView";
            dayThreeView.RowTemplate.Height = 25;
            dayThreeView.Size = new Size(94, 241);
            dayThreeView.TabIndex = 10;
            // 
            // dayTwoView
            // 
            dayTwoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayTwoView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayTwoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayTwoView.Location = new Point(555, 130);
            dayTwoView.Name = "dayTwoView";
            dayTwoView.RowTemplate.Height = 25;
            dayTwoView.Size = new Size(94, 241);
            dayTwoView.TabIndex = 11;
            // 
            // dayOneView
            // 
            dayOneView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dayOneView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dayOneView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayOneView.Location = new Point(655, 130);
            dayOneView.Name = "dayOneView";
            dayOneView.RowTemplate.Height = 25;
            dayOneView.Size = new Size(94, 241);
            dayOneView.TabIndex = 12;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(caloriesTextBox);
            inputBox.Controls.Add(foodTextBox);
            inputBox.Controls.Add(foodLabel);
            inputBox.Controls.Add(caloriesLabel);
            inputBox.Controls.Add(deleteButton);
            inputBox.Controls.Add(editButton);
            inputBox.Controls.Add(addButton);
            inputBox.ForeColor = SystemColors.ButtonHighlight;
            inputBox.Location = new Point(476, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(273, 90);
            inputBox.TabIndex = 17;
            inputBox.TabStop = false;
            inputBox.Text = "Input Here";
            inputBox.Enter += inputBox_Enter;
            // 
            // CaloriesManager
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
            Name = "CaloriesManager";
            Text = "CaloriesManager";
            Load += CaloriesManager_Load;
            Resize += CaloriesManager_Resize;
            ((System.ComponentModel.ISupportInitialize)daySevenView).EndInit();
            ((System.ComponentModel.ISupportInitialize)daySixView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayFiveView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayFourView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayThreeView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayTwoView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayOneView).EndInit();
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label managerLabel;
        private Button addButton;
        private TextBox foodTextBox;
        private TextBox caloriesTextBox;
        private Label foodLabel;
        private Label caloriesLabel;
        private Button editButton;
        private Button deleteButton;
        private DataGridView daySevenView;
        private Button mainMenuButton;
        private DataGridView daySixView;
        private DataGridView dayFiveView;
        private DataGridView dayFourView;
        private DataGridView dayThreeView;
        private DataGridView dayTwoView;
        private DataGridView dayOneView;
        private GroupBox inputBox;
    }
}