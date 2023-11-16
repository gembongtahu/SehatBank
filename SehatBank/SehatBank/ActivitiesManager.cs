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
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private Rectangle mmButton, aButton, eButton, dButton, originalSize;
        private Rectangle daySeven, daySix, dayFive, dayFour, dayThree, dayTwo, dayOne;
        private Rectangle mLabel, fLabel;
        private Rectangle fTextBox;
        private Rectangle iBox;
        private Font mFont, fFont;
        Resize resize = new Resize();
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
            con = new NpgsqlConnection(UserSession.constring);
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
            fLabel = activitiesLabel.Bounds;
            fTextBox = activitiesTextBox.Bounds;
            iBox = inputBox.Bounds;
            mFont = managerLabel.Font;
            fFont = activitiesLabel.Font;
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 1 and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 2 and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 3 and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 4 and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 5 and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
            sqlCommandList.Add("SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned\r\nFROM activities_list al\r\nJOIN users ON al.user_id = users.user_id\r\nJOIN activities ON al.activities_id = activities.activities_id\r\nWHERE al.date = current_date - 6 and al.user_id = @userID\r\nORDER BY al.activities_list_id;");
        }

        private void ActivitiesManager_Resize(object sender, EventArgs e)
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
            resize.resizeControl(fLabel, activitiesLabel, originalSize, this.Width, this.Height);
            resize.resizeControl(fTextBox, activitiesTextBox, originalSize, this.Width, this.Height);
            resize.resizeControl(iBox, inputBox, originalSize, this.Width, this.Height);
            resize.resizeFont(fFont, activitiesLabel, originalSize, this.Height);
            resize.resizeFont(mFont, managerLabel, originalSize, this.Height);
        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int activitiesId = Activities.GetActivitiesId(activitiesTextBox.Text);
            int userId = UserSession.UserId;
            try
            {
                con.Open();
                sql = "select * from alt_insert(:_user_id, :_activities_id)";
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("_activities_id", activitiesId.ToString());
                cmd.Parameters.AddWithValue("_user_id", userId.ToString());
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Insert Sukses");
                    activitiesTextBox.Text = null;
                }
                con.Close();
                dayOneButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataView.Rows[e.RowIndex];
                activitiesTextBox.Text = r.Cells["activities_name"].Value.ToString();
            }
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = null;
                sql = "select * from at_delete(:_activities_list_id)";
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("_activities_list_id", r.Cells["activities_list_id"].Value.ToString());
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Delete Sukses");
                    activitiesTextBox = null;
                    r = null;
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
            try
            {
                con.Open();
                sql = "select * from at_update(:_activities_list_id, :_activities_id)";
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("_activities_list_id", r.Cells["activities_list_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_activities_id", Activities.GetActivitiesId(activitiesTextBox.Text).ToString());
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Edit Sukses");
                    activitiesTextBox = null;
                    r = null;
                }
                con.Close();
                dayOneButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
