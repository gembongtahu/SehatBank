﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SehatBank
{
    public partial class DatabaseManager : Form
    {
        private NpgsqlConnection con;
        string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
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
            con = new NpgsqlConnection(constring);
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
    }
}
