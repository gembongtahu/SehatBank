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
    public partial class MainMenu : Form
    {
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
    }
}
