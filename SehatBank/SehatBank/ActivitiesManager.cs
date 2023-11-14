using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehatBank
{
    public partial class ActivitiesManager : Form
    {
        private Rectangle mmButton, aButton, eButton, dButton, originalSize;
        private Rectangle daySeven, daySix, dayFive, dayFour, dayThree, dayTwo, dayOne;
        private Rectangle mLabel, fLabel, cLabel;
        private Rectangle fTextBox, cTextBox;
        private Rectangle iBox;
        private Font mFont, fFont, cFont;
        Resize resize = new Resize();
        public ActivitiesManager()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMenuButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivitiesManager_Load(object sender, EventArgs e)
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
            fLabel = activitiesLabel.Bounds;
            cLabel = caloriesBurnedLabel.Bounds;
            fTextBox = activitiesTextBox.Bounds;
            cTextBox = caloriesBurnedTextBox.Bounds;
            iBox = inputBox.Bounds;
            mFont = managerLabel.Font;
            fFont = activitiesLabel.Font;
            cFont = caloriesBurnedLabel.Font;
        }

        private void ActivitiesManager_Resize(object sender, EventArgs e)
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
            resize.resizeControl(fLabel, activitiesLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(cLabel, caloriesBurnedLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(fTextBox, activitiesTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(cTextBox, caloriesBurnedTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(iBox, inputBox, originalSize, this.Width, this.Height);
            resize.resizeFont(cFont, caloriesBurnedLabel, originalSize, this.Height);
            resize.resizeFont(fFont, activitiesLabel, originalSize, this.Height);
            resize.resizeFont(mFont, managerLabel, originalSize, this.Height);
        }
    }
}
