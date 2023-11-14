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
    public partial class MainMenu : Form
    {
        private Rectangle qButton, aButton, cButton, dButton, originalSize;
        private Rectangle mmLabel;
        private Font mmFont;
        Resize resize = new Resize();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void caloriesManagerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaloriesManager caloriesManager = new CaloriesManager();
            caloriesManager.ShowDialog();
            this.Show();
        }

        private void activitiesManagerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivitiesManager activitiesManager = new ActivitiesManager();
            activitiesManager.ShowDialog();
            this.Show();
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.ShowDialog();
            this.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            originalSize = this.Bounds;
            qButton = quitButton.Bounds;
            aButton = activitiesManagerButton.Bounds;
            cButton = caloriesManagerButton.Bounds;
            dButton = databaseButton.Bounds;
            mmLabel = mainMenuLabel.Bounds;
            mmFont = mainMenuLabel.Font;
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(qButton, quitButton, originalSize, this.Width, this.Height);
            resize.resizeControl(aButton, activitiesManagerButton, originalSize, this.Width, this.Height);
            resize.resizeControl(cButton, caloriesManagerButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dButton, databaseButton, originalSize, this.Width, this.Height);
            resize.resizeControl(mmLabel, mainMenuLabel, originalSize, this.Width, this.Height);
            resize.resizeFont(mmFont, mainMenuLabel, originalSize, this.Height);
        }
    }
}
