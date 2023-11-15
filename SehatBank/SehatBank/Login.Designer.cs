namespace SehatBank
{
    partial class Login
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
            appNameLabel = new Label();
            welcomeLabel = new Label();
            inputBox = new GroupBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            registerButton = new Button();
            loginButton = new Button();
            inputBox.SuspendLayout();
            SuspendLayout();
            // 
            // appNameLabel
            // 
            appNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appNameLabel.AutoSize = true;
            appNameLabel.Font = new Font("Heebo", 72F, FontStyle.Regular, GraphicsUnit.Point);
            appNameLabel.ForeColor = SystemColors.ButtonHighlight;
            appNameLabel.Location = new Point(124, 48);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(542, 141);
            appNameLabel.TabIndex = 27;
            appNameLabel.Text = "Sehat Bank";
            appNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Heebo", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.ForeColor = SystemColors.ButtonHighlight;
            welcomeLabel.Location = new Point(147, 177);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(489, 55);
            welcomeLabel.TabIndex = 28;
            welcomeLabel.Text = "Welcome to Sehat Bank App";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(passwordTextBox);
            inputBox.Controls.Add(usernameTextBox);
            inputBox.Controls.Add(usernameLabel);
            inputBox.Controls.Add(passwordLabel);
            inputBox.Controls.Add(registerButton);
            inputBox.Controls.Add(loginButton);
            inputBox.ForeColor = SystemColors.ButtonHighlight;
            inputBox.Location = new Point(231, 252);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(323, 90);
            inputBox.TabIndex = 29;
            inputBox.TabStop = false;
            inputBox.Text = "Enter your username and password here";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(109, 48);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(109, 25);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
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
            passwordLabel.Location = new Point(23, 48);
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
            registerButton.Location = new Point(227, 47);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 3;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.BackColor = Color.DimGray;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(227, 25);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(inputBox);
            Controls.Add(welcomeLabel);
            Controls.Add(appNameLabel);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            Resize += Login_Resize;
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appNameLabel;
        private Label welcomeLabel;
        private GroupBox inputBox;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button registerButton;
        private Button loginButton;
    }
}