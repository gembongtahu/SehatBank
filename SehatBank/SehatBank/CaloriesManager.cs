using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehatBank
{
    public partial class CaloriesManager : Form
    {
        private Rectangle mmButton, aButton, eButton, dButton, originalSize;
        private Rectangle daySeven, daySix, dayFive, dayFour, dayThree, dayTwo, dayOne;
        private Rectangle mLabel, fLabel, cLabel;
        private Rectangle fTextBox, cTextBox;
        private Rectangle iBox;
        private Font mFont, fFont, cFont;

        public CaloriesManager()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaloriesManager_Load(object sender, EventArgs e)
        {
            originalSize = this.Bounds;
            mmButton = mainMenuButton.Bounds;
            aButton = addButton.Bounds;
            eButton = editButton.Bounds;
            dButton = deleteButton.Bounds;
            daySeven = daySevenView.Bounds;
            dayFive = dayFiveView.Bounds;
            daySix = daySixView.Bounds;
            dayOne = dayOneView.Bounds;
            dayTwo = dayTwoView.Bounds;
            dayThree = dayThreeView.Bounds;
            dayFour = dayFourView.Bounds;
            mLabel = managerLabel.Bounds;
            fLabel = foodLabel.Bounds;
            cLabel = caloriesLabel.Bounds;
            fTextBox = foodTextBox.Bounds;
            cTextBox = caloriesTextBox.Bounds;
            iBox = inputBox.Bounds;
            mFont = managerLabel.Font;
            fFont = foodLabel.Font;
            cFont = caloriesLabel.Font;
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalSize.Width), yRatio = (float)(this.Height) / (float)(originalSize.Height);
            int newX = (int)(r.X * xRatio), newY = (int)(r.Y * yRatio), newWidth = (int)(r.Width * xRatio), newHeight = (int)(r.Height * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void resizeFont(Font f, Control c)
        {
            float ratio = (float)this.Height / (float)originalSize.Height;
            int newSize = (int)(f.Size * ratio);
            c.Font = new Font(f.FontFamily, newSize, f.Style);
        }

        private void CaloriesManager_Resize(object sender, EventArgs e)
        {
            resizeControl(mmButton, mainMenuButton);
            resizeControl(aButton, addButton);
            resizeControl(eButton, editButton);
            resizeControl(dButton, deleteButton);
            resizeControl(dayOne, dayOneView);
            resizeControl(dayTwo, dayTwoView);
            resizeControl(dayThree, dayThreeView);
            resizeControl(dayFour, dayFourView);
            resizeControl(dayFive, dayFiveView);
            resizeControl(daySix, daySixView);
            resizeControl(daySeven, daySevenView);
            resizeControl(mLabel, managerLabel);
            resizeControl(fLabel, foodLabel);
            resizeControl(cLabel, caloriesLabel);
            resizeControl(fTextBox, foodTextBox);
            resizeControl(cTextBox, caloriesTextBox);
            resizeControl(iBox, inputBox);
            resizeFont(cFont, caloriesLabel);
            resizeFont(fFont, foodLabel);
            resizeFont(mFont, managerLabel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
