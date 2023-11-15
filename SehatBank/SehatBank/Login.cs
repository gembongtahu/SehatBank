using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SehatBank
{
    public partial class Login : Form
    {
        private Rectangle lButton, rButton, originalSize;
        private Rectangle aLabel, wLabel, uLabel, pLabel;
        private Rectangle uTextBox, pTextBox;
        private Rectangle iBox;
        private Font aFont, wFont, uFont, pFont;
        Resize resize = new Resize();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            originalSize = this.Bounds;
            rButton = registerButton.Bounds;
            lButton = loginButton.Bounds;
            uLabel = usernameLabel.Bounds;
            pLabel = passwordLabel.Bounds;
            wLabel = welcomeLabel.Bounds;
            aLabel = appNameLabel.Bounds;
            uTextBox = usernameTextBox.Bounds;
            pTextBox = passwordTextBox.Bounds;
            iBox = inputBox.Bounds;
            uFont = usernameLabel.Font;
            pFont = passwordLabel.Font;
            wFont = welcomeLabel.Font;
            aFont = appNameLabel.Font;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (User.AuthenticateUser(usernameTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Login Success");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }
            else MessageBox.Show("Username atau Password yang anda masukkan salah!");
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(rButton, registerButton, originalSize, this.Width, this.Height);
            resize.resizeControl(lButton, loginButton, originalSize, this.Width, this.Height);
            resize.resizeControl(aLabel, appNameLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(uLabel, usernameLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(pLabel, passwordLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(wLabel, welcomeLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(uTextBox, usernameTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(pTextBox, passwordTextBox, originalSize, this.Width, this.Height);
            resize.resizeFont(uFont, usernameLabel, originalSize, this.Height);
            resize.resizeFont(pFont, passwordLabel, originalSize, this.Height);
            resize.resizeFont(wFont, welcomeLabel, originalSize, this.Height);
            resize.resizeFont(aFont, appNameLabel, originalSize, this.Height);
            resize.resizeControl(iBox, inputBox, originalSize, this.Width, this.Height);
        }
    }
}
