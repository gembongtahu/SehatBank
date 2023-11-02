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
        Resize resize = new Resize();

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

        private void CaloriesManager_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(mmButton, mainMenuButton, originalSize, this.Width, this.Height);
            resize.resizeControl(aButton, addButton, originalSize, this.Width, this.Height);
            resize.resizeControl(eButton, editButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dButton, deleteButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dayOne, dayOneView, originalSize, this.Width, this.Height);
            resize.resizeControl(dayTwo, dayTwoView, originalSize, this.Width, this.Height);
            resize.resizeControl(dayThree, dayThreeView, originalSize, this.Width, this.Height);
            resize.resizeControl(dayFour, dayFourView, originalSize, this.Width, this.Height);
            resize.resizeControl(dayFive, dayFiveView, originalSize, this.Width, this.Height);
            resize.resizeControl(daySix, daySixView, originalSize, this.Width, this.Height);
            resize.resizeControl(daySeven, daySevenView, originalSize, this.Width, this.Height);
            resize.resizeControl(mLabel, managerLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(fLabel, foodLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(cLabel, caloriesLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(fTextBox, foodTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(cTextBox, caloriesTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(iBox, inputBox, originalSize, this.Width, this.Height);
            resize.resizeFont(cFont, caloriesLabel, originalSize, this.Height);
            resize.resizeFont(fFont, foodLabel, originalSize, this.Height);
            resize.resizeFont(mFont, managerLabel, originalSize, this.Height);
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
