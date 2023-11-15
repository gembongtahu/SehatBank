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
        private Rectangle rButton, originalSize;
        private Rectangle rLabel, uLabel, pLabel, wLabel, hLabel, gLabel;
        private Rectangle uTextBox, pTextBox, wTextBox, hTextBox;
        private Rectangle mRadioButton, fRadioButton;
        private Rectangle iBox;
        private Font rFont, uFont, pFont, wFont, hFont, gFont;
        Resize resize = new Resize();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            originalSize = this.Bounds;
            rButton = registerButton.Bounds;
            mRadioButton = maleButton.Bounds;
            fRadioButton = femaleButton.Bounds;
            rLabel = registerLabel.Bounds;
            uLabel = usernameLabel.Bounds;
            pLabel = passwordLabel.Bounds;
            wLabel = weightLabel.Bounds;
            hLabel = heightLabel.Bounds;
            gLabel = genderLabel.Bounds;
            uTextBox = usernameTextBox.Bounds;
            pTextBox = passwordTextBox.Bounds;
            wTextBox = weightTextBox.Bounds;
            hTextBox = heightTextBox.Bounds;
            iBox = inputBox.Bounds;
            rFont = registerLabel.Font;
            uFont = usernameLabel.Font;
            pFont = passwordLabel.Font;
            wFont = weightLabel.Font;
            hFont = heightLabel.Font;
            gFont = genderLabel.Font;
        }

        private void Register_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(rButton, registerButton, originalSize, this.Width, this.Height);
            resize.resizeControl(mRadioButton, maleButton, originalSize, this.Width, this.Height);
            resize.resizeControl(fRadioButton, femaleButton, originalSize, this.Width, this.Height);
            resize.resizeControl(rLabel, registerLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(uLabel, usernameLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(pLabel, passwordLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(wLabel, weightLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(hLabel, heightLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(gLabel, genderLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(uTextBox, usernameTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(pTextBox, passwordTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(wTextBox, weightTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(hTextBox, heightTextBox, originalSize, this.Width, this.Height);
            resize.resizeFont(rFont, registerLabel, originalSize, this.Height);
            resize.resizeFont(uFont, usernameLabel, originalSize, this.Height);
            resize.resizeFont(pFont, passwordLabel, originalSize, this.Height);
            resize.resizeFont(wFont, weightLabel, originalSize, this.Height);
            resize.resizeFont(hFont, heightLabel, originalSize, this.Height);
            resize.resizeFont(gFont, genderLabel, originalSize, this.Height);
            resize.resizeControl(iBox, inputBox, originalSize, this.Width, this.Height);
        }
    }
}
