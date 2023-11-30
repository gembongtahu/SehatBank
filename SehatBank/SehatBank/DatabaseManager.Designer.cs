namespace SehatBank
{
    partial class DatabaseManager
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
            mainMenuButton = new Button();
            showActivitiesButton = new Button();
            showFoodButton = new Button();
            foodDataView = new DataGridView();
            activitiesDataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)foodDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activitiesDataView).BeginInit();
            SuspendLayout();
            // 
            // managerLabel
            // 
            managerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managerLabel.AutoSize = true;
            managerLabel.Font = new Font("Heebo", 48F, FontStyle.Regular, GraphicsUnit.Point);
            managerLabel.ForeColor = SystemColors.ButtonHighlight;
            managerLabel.Location = new Point(115, -1);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(580, 94);
            managerLabel.TabIndex = 2;
            managerLabel.Text = "Database Manager";
            managerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackColor = Color.DimGray;
            mainMenuButton.ForeColor = SystemColors.ButtonHighlight;
            mainMenuButton.Location = new Point(667, 415);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(107, 23);
            mainMenuButton.TabIndex = 4;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = false;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // showActivitiesButton
            // 
            showActivitiesButton.BackColor = Color.DimGray;
            showActivitiesButton.ForeColor = SystemColors.ButtonHighlight;
            showActivitiesButton.Location = new Point(512, 83);
            showActivitiesButton.Name = "showActivitiesButton";
            showActivitiesButton.Size = new Size(157, 23);
            showActivitiesButton.TabIndex = 1;
            showActivitiesButton.Text = "Show Activities Database";
            showActivitiesButton.UseVisualStyleBackColor = false;
            showActivitiesButton.Click += showActivitiesButton_Click;
            // 
            // showFoodButton
            // 
            showFoodButton.BackColor = Color.DimGray;
            showFoodButton.ForeColor = SystemColors.ButtonHighlight;
            showFoodButton.Location = new Point(135, 83);
            showFoodButton.Name = "showFoodButton";
            showFoodButton.Size = new Size(157, 23);
            showFoodButton.TabIndex = 0;
            showFoodButton.Text = "Show Food Database";
            showFoodButton.UseVisualStyleBackColor = false;
            showFoodButton.Click += showFoodButton_Click;
            // 
            // foodDataView
            // 
            foodDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foodDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foodDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodDataView.Location = new Point(68, 112);
            foodDataView.Name = "foodDataView";
            foodDataView.RowTemplate.Height = 25;
            foodDataView.Size = new Size(283, 287);
            foodDataView.TabIndex = 2;
            // 
            // activitiesDataView
            // 
            activitiesDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            activitiesDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            activitiesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activitiesDataView.Location = new Point(447, 112);
            activitiesDataView.Name = "activitiesDataView";
            activitiesDataView.RowTemplate.Height = 25;
            activitiesDataView.Size = new Size(283, 287);
            activitiesDataView.TabIndex = 3;
            // 
            // DatabaseManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(activitiesDataView);
            Controls.Add(foodDataView);
            Controls.Add(showFoodButton);
            Controls.Add(showActivitiesButton);
            Controls.Add(mainMenuButton);
            Controls.Add(managerLabel);
            Name = "DatabaseManager";
            Text = "DatabaseManager";
            Load += DatabaseManager_Load;
            Resize += DatabaseManager_Resize;
            ((System.ComponentModel.ISupportInitialize)foodDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)activitiesDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label managerLabel;
        private Button mainMenuButton;
        private Button showActivitiesButton;
        private Button showFoodButton;
        private DataGridView foodDataView;
        private DataGridView activitiesDataView;
    }
}