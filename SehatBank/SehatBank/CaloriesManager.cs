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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SehatBank
{
    public partial class CaloriesManager : Form
    {
        private NpgsqlConnection con;
        string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
        public DataTable dt;
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
        List<string> sqlCommandList = new List<string>();
        List<string> foodList = new List<string>();

        public CaloriesManager()
        {
            InitializeComponent();
            foodList = Food.GetFoodList();
            foreach (string food in foodList)
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
            daySeven = daySevenButton.Bounds;
            dayFive = dayFiveButton.Bounds;
            daySix = daySixButton.Bounds;
            dayOne = dayOneButton.Bounds;
            dayTwo = dayTwoButton.Bounds;
            dayThree = dayThreeButton.Bounds;
            dayFour = dayFourButton.Bounds;
            mLabel = managerLabel.Bounds;
            fLabel = foodLabel.Bounds;
            cLabel = caloriesLabel.Bounds;
            fTextBox = foodTextBox.Bounds;
            cTextBox = caloriesTextBox.Bounds;
            iBox = inputBox.Bounds;
            mFont = managerLabel.Font;
            fFont = foodLabel.Font;
            cFont = caloriesLabel.Font;
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 1 and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 2 and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 3 and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 4 and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 5 and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
            sqlCommandList.Add("SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories\r\nFROM calories_intake_list cil\r\nJOIN users ON cil.user_id = users.user_id\r\nJOIN food ON cil.food_id = food.food_id\r\nWHERE cil.date = current_date - 6 and cil.user_id = @userID\r\nORDER BY cil.calories_intake_id;\r\n\r\n");
        }

        private void CaloriesManager_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(mmButton, mainMenuButton, originalSize, this.Width, this.Height);
            resize.resizeControl(aButton, addButton, originalSize, this.Width, this.Height);
            resize.resizeControl(eButton, editButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dButton, deleteButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dayOne, dayOneButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dayTwo, dayTwoButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dayThree, dayThreeButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dayFour, dayFourButton, originalSize, this.Width, this.Height);
            resize.resizeControl(dayFive, dayFiveButton, originalSize, this.Width, this.Height);
            resize.resizeControl(daySix, daySixButton, originalSize, this.Width, this.Height);
            resize.resizeControl(daySeven, daySevenButton, originalSize, this.Width, this.Height);
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
            int foodId = Food.GetFoodId(foodTextBox.Text);
            int userId = UserSession.UserId;
            try
            {
                con.Open();
                sql = "select * from ct_insert(:_user_id, :_food_id)";
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("_food_id", foodId.ToString());
                cmd.Parameters.AddWithValue("_user_id", userId.ToString());
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Insert Sukses");
                    foodTextBox.Text = null;
                }
                con.Close();
                dayOneButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        }

        private void dayOneButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[0];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dayTwoButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[1];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dayThreeButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[2];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dayFourButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[3];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dayFiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[4];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void daySixButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[5];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void daySevenButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = sqlCommandList[6];
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId.ToString());
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
