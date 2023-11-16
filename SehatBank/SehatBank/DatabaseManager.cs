using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SehatBank
{
    public partial class DatabaseManager : Form
    {
        private NpgsqlConnection con;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private Rectangle mmButton, aButton, fButton, originalSize;
        private Rectangle fView, aView;
        private Rectangle mLabel;
        private Font mFont;
        Resize resize = new Resize();
        public DatabaseManager()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showFoodButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                foodDataView.DataSource = null;
                sql = "select * from foodtable_select()";
                cmd = new NpgsqlCommand(sql, con);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foodDataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatabaseManager_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(UserSession.constring);
            originalSize = this.Bounds;
            mmButton = mainMenuButton.Bounds;
            aButton = showActivitiesButton.Bounds;
            fButton = showFoodButton.Bounds;
            fView = foodDataView.Bounds;
            aView = activitiesDataView.Bounds;
            mLabel = managerLabel.Bounds;
            mFont = managerLabel.Font;
        }

        private void showActivitiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                activitiesDataView.DataSource = null;
                sql = "select * from activitiestable_select()";
                cmd = new NpgsqlCommand(sql, con);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                activitiesDataView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatabaseManager_Resize(object sender, EventArgs e)
        {
            resize.resizeControl(mmButton, mainMenuButton, originalSize, this.Width, this.Height);
            resize.resizeControl(aButton, showActivitiesButton, originalSize, this.Width, this.Height);
            resize.resizeControl(fButton, showFoodButton, originalSize, this.Width, this.Height);
            resize.resizeControl(fView, foodDataView, originalSize, this.Width, this.Height);
            resize.resizeControl(aView, activitiesDataView, originalSize, this.Width, this.Height);
            resize.resizeControl(mLabel, managerLabel, originalSize, this.Width, this.Height);
            resize.resizeFont(mFont, managerLabel, originalSize, this.Height);
        }
    }
}
