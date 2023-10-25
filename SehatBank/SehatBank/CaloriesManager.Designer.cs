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
            label1 = new Label();
            mainMenuButton = new Button();
            addButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(140, 52);
            label1.Name = "label1";
            label1.Size = new Size(544, 94);
            label1.TabIndex = 1;
            label1.Text = "Calories Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackColor = Color.DimGray;
            mainMenuButton.ForeColor = SystemColors.ButtonHighlight;
            mainMenuButton.Location = new Point(625, 378);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(107, 23);
            mainMenuButton.TabIndex = 2;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = false;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DimGray;
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(286, 225);
            addButton.Name = "addButton";
            addButton.Size = new Size(67, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(159, 167);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 6;
            label2.Text = "Food Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(181, 195);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 7;
            label3.Text = "Calories:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CaloriesManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(addButton);
            Controls.Add(mainMenuButton);
            Controls.Add(label1);
            Name = "CaloriesManager";
            Text = "CaloriesManager";
            Load += CaloriesManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button mainMenuButton;
        private Button addButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}