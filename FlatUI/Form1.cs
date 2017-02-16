using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.IO;

namespace FlatUI
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            /*
            string myConnection = "datasource = localhost; port = 3306; username = root; password=";

            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlConnection MySqlDataAdapter = new MySqlConnection();
                MySqlDataAdapter.SelectCommand = new MySqlCommand("select * database.edata ;", myConn);
                //DataSet ds = new DataSet();
                MySqlCommandBuilder cb = new MySqlCommandBuilder(MySqlDataAdapter);
                myConn.Open();
                MessageBox.Show("connect");
                myConn.Clone();
            }
            catch
            {
                MessageBox.Show("not connect");
            }
            */
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(ucDash.Instance))
            {
                panel3.Controls.Add(ucDash.Instance);
                ucDash.Instance.Dock = DockStyle.Fill;
                ucDash.Instance.BringToFront();
            }
            else
                ucDash.Instance.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(ucSales.Instance))
            {
                panel3.Controls.Add(ucSales.Instance);
                ucSales.Instance.Dock = DockStyle.Fill;
                ucSales.Instance.BringToFront();
            }
            else
                ucSales.Instance.BringToFront();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
