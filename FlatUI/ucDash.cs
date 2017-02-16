using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace FlatUI
{
    
    public partial class ucDash : UserControl
    {
        //int total_count;
        private OleDbConnection connection = new OleDbConnection();
        private static ucDash _instance;
        public static ucDash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDash();
                return _instance;
            }
                
        }
        public ucDash()
        {
            
            InitializeComponent();
            string fileName = "DB1.accdb";
            string fullPath; ;
            fullPath = Path.GetFullPath(fileName);
            //MessageBox.Show(fullPath);
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + fullPath + "; Persist Security Info = False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //ok button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * from EmployeeData where ID = '" + Barcode.Text + "' ";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                int rcv = 1;
                while (reader.Read())
                {
                    count = count + 1;
                    Result_label.Text = "Name: " + reader["FName"].ToString();

                    rcv = int.Parse(reader["PrintCount"].ToString());
                    //MessageBox.Show(rcv.ToString());
                }

                connection.Close();


                if (count == 1 && rcv == 1)
                {
                    distribute_candy();
                    label2.Text = "Sugar daddy, Please give Candy!!!";

                }
                else if (count == 1 && rcv == 0)
                {
//                    MessageBox.Show(" ");
                    label2.Text = "Gotcha!! Jerk. Want double portion?!";

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicated Employee Data ");
                }
                else
                {
                    MessageBox.Show("No such Employee");
                    
                }
                update_datagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void distribute_candy()
        {
            connection.Open();
            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = connection;
            string query = "update EmployeeData set PrintCount = '0' where ID = '" + Barcode.Text + "' ";
            //MessageBox.Show(query);
            command3.CommandText = query;
            command3.ExecuteNonQuery();
            //MessageBox.Show("Data saved !!");
            connection.Close();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            for (int i = 1; i <= 80; i++)
            {
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string query = "update EmployeeData set PrintCount = '1' where ID1 = " + i + " ";
                //MessageBox.Show(query);
                command2.CommandText = query;
                command2.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void tabEmp_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DB_con.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Barcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void usDash(object sender, KeyEventArgs e)
        {
           
        }

        private void Barcode_keydown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    OK_button.PerformClick();
                    Barcode.Text = string.Empty;
                    Barcode.Focus();
                }                
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error  " + ex);
            }
        }
        
        /* 
      * display data on the GridView 
      */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void update_datagridview()
        {
            try
            {
                
                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = connection;                
                string query3 = "select FName from EmployeeData where PrintCount = 1 ";
                //MessageBox.Show(query3);
                command3.CommandText = query3;
                OleDbDataAdapter da = new OleDbDataAdapter(command3);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
    }
} 