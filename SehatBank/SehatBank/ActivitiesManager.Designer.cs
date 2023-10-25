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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            addButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            mainMenuButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(125, 71);
            label1.Name = "label1";
            label1.Size = new Size(573, 94);
            label1.TabIndex = 2;
            label1.Text = "Activities Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(151, 211);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 11;
            label2.Text = "Workout Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DimGray;
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(305, 241);
            addButton.Name = "addButton";
            addButton.Size = new Size(67, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Heebo", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(195, 178);
            label4.Name = "label4";
            label4.Size = new Size(137, 31);
            label4.TabIndex = 13;
            label4.Text = "Add Workout";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Heebo", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(458, 178);
            label3.Name = "label3";
            label3.Size = new Size(143, 31);
            label3.TabIndex = 17;
            label3.Text = "Add Activities";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(414, 211);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 16;
            label5.Text = "Activities Name:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(535, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(568, 241);
            button1.Name = "button1";
            button1.Size = new Size(67, 23);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackColor = Color.DimGray;
            mainMenuButton.ForeColor = SystemColors.ButtonHighlight;
            mainMenuButton.Location = new Point(625, 378);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(107, 23);
            mainMenuButton.TabIndex = 18;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = false;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // ActivitiesManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuButton);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(addButton);
            Controls.Add(label1);
            Name = "ActivitiesManager";
            Text = "ActivitiesManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button addButton;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBox2;
        private Button button1;
        private Button mainMenuButton;
    }
}