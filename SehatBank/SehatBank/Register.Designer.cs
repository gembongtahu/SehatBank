namespace SehatBank
{
    partial class Register
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
            registerLabel = new Label();
            inputBox = new GroupBox();
            loginButton = new Button();
            ageTextBox = new TextBox();
            ageLabel = new Label();
            femaleButton = new RadioButton();
            maleButton = new RadioButton();
            genderLabel = new Label();
            heightTextBox = new TextBox();
            weightTextBox = new TextBox();
            weightLabel = new Label();
            heightLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            registerButton = new Button();
            inputBox.SuspendLayout();
            SuspendLayout();
            // 
            // registerLabel
            // 
            registerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Heebo", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerLabel.ForeColor = SystemColors.ButtonHighlight;
            registerLabel.Location = new Point(283, 39);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(256, 55);
            registerLabel.TabIndex = 29;
            registerLabel.Text = "Register Form";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(loginButton);
            inputBox.Controls.Add(ageTextBox);
            inputBox.Controls.Add(ageLabel);
            inputBox.Controls.Add(femaleButton);
            inputBox.Controls.Add(maleButton);
            inputBox.Controls.Add(genderLabel);
            inputBox.Controls.Add(heightTextBox);
            inputBox.Controls.Add(weightTextBox);
            inputBox.Controls.Add(weightLabel);
            inputBox.Controls.Add(heightLabel);
            inputBox.Controls.Add(passwordTextBox);
            inputBox.Controls.Add(usernameTextBox);
            inputBox.Controls.Add(usernameLabel);
            inputBox.Controls.Add(passwordLabel);
            inputBox.Controls.Add(registerButton);
            inputBox.ForeColor = SystemColors.ButtonHighlight;
            inputBox.Location = new Point(68, 97);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(655, 319);
            inputBox.TabIndex = 30;
            inputBox.TabStop = false;
            inputBox.Text = "Enter you identity here";
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.BackColor = Color.DimGray;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(0, 199);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(655, 120);
            loginButton.TabIndex = 8;
            loginButton.Text = "Back to Login Page";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(109, 117);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(540, 23);
            ageTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            ageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.ForeColor = SystemColors.ButtonHighlight;
            ageLabel.Location = new Point(63, 117);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(40, 22);
            ageLabel.TabIndex = 17;
            ageLabel.Text = "Age:";
            ageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Location = new Point(158, 142);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(63, 19);
            femaleButton.TabIndex = 6;
            femaleButton.TabStop = true;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Location = new Point(109, 142);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(51, 19);
            maleButton.TabIndex = 5;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderLabel.ForeColor = SystemColors.ButtonHighlight;
            genderLabel.Location = new Point(42, 139);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(61, 22);
            genderLabel.TabIndex = 13;
            genderLabel.Text = "Gender:";
            genderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(109, 94);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(540, 23);
            heightTextBox.TabIndex = 3;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(109, 71);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(540, 23);
            weightTextBox.TabIndex = 2;
            // 
            // weightLabel
            // 
            weightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel.ForeColor = SystemColors.ButtonHighlight;
            weightLabel.Location = new Point(43, 70);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(60, 22);
            weightLabel.TabIndex = 10;
            weightLabel.Text = "Weight:";
            weightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightLabel
            // 
            heightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            heightLabel.ForeColor = SystemColors.ButtonHighlight;
            heightLabel.Location = new Point(45, 94);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(58, 22);
            heightLabel.TabIndex = 11;
            heightLabel.Text = "Height:";
            heightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(109, 48);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(540, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(109, 25);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(540, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonHighlight;
            usernameLabel.Location = new Point(21, 24);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(82, 22);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Heebo", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = SystemColors.ButtonHighlight;
            passwordLabel.Location = new Point(23, 46);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 22);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerButton.BackColor = Color.DimGray;
            registerButton.ForeColor = SystemColors.ButtonHighlight;
            registerButton.Location = new Point(562, 168);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(87, 23);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(inputBox);
            Controls.Add(registerLabel);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            Resize += Register_Resize;
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerLabel;
        private GroupBox inputBox;
        private TextBox textBox1;
        private Label genderLabel;
        private TextBox heightTextBox;
        private TextBox weightTextBox;
        private Label weightLabel;
        private Label heightLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button registerButton;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private TextBox ageTextBox;
        private Label ageLabel;
        private Button loginButton;
    }
}