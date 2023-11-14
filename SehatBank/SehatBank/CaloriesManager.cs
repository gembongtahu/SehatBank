using Npgsql;
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
        private NpgsqlConnection con;
        string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
        public DataTable dtOne, dtTwo, dtThree, dtFour, dtFive, dtSix, dtSeven;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private Rectangle mmButton, aButton, eButton, dButton, originalSize;
        private Rectangle daySeven, daySix, dayFive, dayFour, dayThree, dayTwo, dayOne;
        private Rectangle mLabel, fLabel, cLabel;
        private Rectangle fTextBox, cTextBox;
        private Rectangle iBox;
        private Font mFont, fFont, cFont;
        Resize resize = new Resize();
        List<DataGridView> dataGridList = new List<DataGridView>();
        List<DataTable> dataTableList = new List<DataTable>();
        List<string> sqlCommandList = new List<string>();
        List<string> foodList = new List<string>();

        public CaloriesManager()
        {
            InitializeComponent();
            foodList = Food.GetFoodList();
            foreach(string food in foodList)
            {
                foodTextBox.AutoCompleteCustomSource.Add(food);
                foodTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                foodTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaloriesManager_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(constring);
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
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 1\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 2\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 3\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 4\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 5\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 6\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
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
