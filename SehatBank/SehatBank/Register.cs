using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SehatBank
{
    public partial class Register : Form
    {
        private NpgsqlConnection con;
        public DataTable dtOne, dtTwo, dtThree, dtFour, dtFive, dtSix, dtSeven;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private Rectangle rButton, originalSize, lButton;
        private Rectangle rLabel, uLabel, pLabel, wLabel, hLabel, gLabel, aLabel;
        private Rectangle uTextBox, pTextBox, wTextBox, hTextBox, aTextBox;
        private Rectangle mRadioButton, fRadioButton;
        private Rectangle iBox;
        private Font rFont, uFont, pFont, wFont, hFont, gFont, aFont;
        Resize resize = new Resize();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(UserSession.constring);
            originalSize = this.Bounds;
            rButton = registerButton.Bounds;
            lButton = loginButton.Bounds;
            mRadioButton = maleButton.Bounds;
            fRadioButton = femaleButton.Bounds;
            rLabel = registerLabel.Bounds;
            uLabel = usernameLabel.Bounds;
            pLabel = passwordLabel.Bounds;
            wLabel = weightLabel.Bounds;
            hLabel = heightLabel.Bounds;
            gLabel = genderLabel.Bounds;
            aLabel = ageLabel.Bounds;
            uTextBox = usernameTextBox.Bounds;
            pTextBox = passwordTextBox.Bounds;
            wTextBox = weightTextBox.Bounds;
            hTextBox = heightTextBox.Bounds;
            aTextBox = ageTextBox.Bounds;
            iBox = inputBox.Bounds;
            rFont = registerLabel.Font;
            uFont = usernameLabel.Font;
            pFont = passwordLabel.Font;
            wFont = weightLabel.Font;
            hFont = heightLabel.Font;
            gFont = genderLabel.Font;
            aFont = ageLabel.Font;
        }

        private void Register_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(rButton, registerButton, originalSize, this.Width, this.Height);
            resize.resizeControl(lButton, loginButton, originalSize, this.Width, this.Height);
            resize.resizeControl(mRadioButton, maleButton, originalSize, this.Width, this.Height);
            resize.resizeControl(fRadioButton, femaleButton, originalSize, this.Width, this.Height);
            resize.resizeControl(rLabel, registerLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(uLabel, usernameLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(pLabel, passwordLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(wLabel, weightLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(hLabel, heightLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(gLabel, genderLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(aLabel, ageLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(uTextBox, usernameTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(pTextBox, passwordTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(wTextBox, weightTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(hTextBox, heightTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(aTextBox, ageTextBox, originalSize, this.Width, this.Height);
            resize.resizeFont(rFont, registerLabel, originalSize, this.Height);
            resize.resizeFont(uFont, usernameLabel, originalSize, this.Height);
            resize.resizeFont(pFont, passwordLabel, originalSize, this.Height);
            resize.resizeFont(wFont, weightLabel, originalSize, this.Height);
            resize.resizeFont(hFont, heightLabel, originalSize, this.Height);
            resize.resizeFont(gFont, genderLabel, originalSize, this.Height);
            resize.resizeFont(aFont, ageLabel, originalSize, this.Height);
            resize.resizeControl(iBox, inputBox, originalSize, this.Width, this.Height);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sql = "select * from user_insert(:_user_name, :_weight, :_height, :_age, :_gender, :_password)";
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("_user_name", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("_weight", Int16.Parse(weightTextBox.Text));
                cmd.Parameters.AddWithValue("_height", Int16.Parse(heightTextBox.Text));
                cmd.Parameters.AddWithValue("_age", Int16.Parse(ageTextBox.Text));
                cmd.Parameters.AddWithValue("_password", passwordTextBox.Text);
                if (maleButton.Checked) cmd.Parameters.AddWithValue("_gender", "Male");
                else if (femaleButton.Checked) cmd.Parameters.AddWithValue("_gender", "Female");
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Registrasi Sukses");
                    usernameTextBox.Text = weightTextBox.Text = heightTextBox.Text = ageTextBox.Text = passwordTextBox.Text = null;
                    maleButton.Checked = femaleButton.Checked = false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
