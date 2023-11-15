using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehatBank
{
    public partial class ActivitiesManager : Form
    {
        private NpgsqlConnection con;
        string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
        public DataTable dtOne, dtTwo, dtThree, dtFour, dtFive, dtSix, dtSeven;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private Rectangle mmButton, aButton, eButton, dButton, originalSize, sButton;
        private Rectangle daySeven, daySix, dayFive, dayFour, dayThree, dayTwo, dayOne;
        private Rectangle mLabel, fLabel, cLabel;
        private Rectangle fTextBox, cTextBox;
        private Rectangle iBox;
        private Font mFont, fFont, cFont;
        Resize resize = new Resize();
        List<DataGridView> dataGridList = new List<DataGridView>();
        List<DataTable> dataTableList = new List<DataTable>();
        List<string> sqlCommandList = new List<string>();
        List<string> activitiesList = new List<string>();

        public ActivitiesManager()
        {
            InitializeComponent();
            activitiesList = Activities.GetActivitiesList();
            foreach (string activity in activitiesList)
            {
                activitiesTextBox.AutoCompleteCustomSource.Add(activity);
                activitiesTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                activitiesTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
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
            con = new NpgsqlConnection(constring);
            originalSize = this.Bounds;
            mmButton = mainMenuButton.Bounds;
            aButton = addButton.Bounds;
            eButton = editButton.Bounds;
            dButton = deleteButton.Bounds;
            sButton = showButton.Bounds;
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
            dataGridList.Add(dayOneView);
            dataGridList.Add(dayTwoView);
            dataGridList.Add(dayThreeView);
            dataGridList.Add(dayFourView);
            dataGridList.Add(dayFiveView);
            dataGridList.Add(daySixView);
            dataGridList.Add(daySevenView);
            dataTableList.Add(dtOne);
            dataTableList.Add(dtTwo);
            dataTableList.Add(dtThree);
            dataTableList.Add(dtFour);
            dataTableList.Add(dtFive);
            dataTableList.Add(dtSix);
            dataTableList.Add(dtSeven);
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 1\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 2\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 3\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 4\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 5\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 6\r\nORDER BY al.activities_list_id;");
        }

        private void ActivitiesManager_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(mmButton, mainMenuButton, originalSize, this.Width, this.Height);
            resize.resizeControl(aButton, addButton, originalSize, this.Width, this.Height);
            resize.resizeControl(eButton, editButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dButton, deleteButton, originalSize, this.Width, this.Height);
            resize.resizeControl(sButton, showButton, originalSize, this.Width, this.Height);
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

        private void showButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                try
                {
                    con.Open();
                    dataTableList[i] = null;
                    sql = sqlCommandList[i];
                    cmd = new NpgsqlCommand(sql, con);
                    dataTableList[i] = new DataTable();
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    dataTableList[i].Load(rd);
                    dataGridList[i].DataSource = dataTableList[i];
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
