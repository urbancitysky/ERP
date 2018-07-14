using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;


namespace FlatUI
{
    public partial class ucHR : UserControl
    {
        private OleDbConnection DB1_con = new OleDbConnection();
        //private OleDbConnection CTconnection = new OleDbConnection();
        private static ucHR _instance;
        public static ucHR Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHR();
                return _instance;
            }
        }

        public ucHR()
        {
            InitializeComponent();
            AutoCompleteText();
            string fileName = "DB1.accdb";            
            string fullPath = Path.GetFullPath(fileName);            
            //MessageBox.Show(fullPath);
            DB1_con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = "+ fullPath + "; Persist Security Info = False;";
            //UpdateDB1();
            update_datagridview();
        }

        private void UpdateDB1()
        {
            throw new NotImplementedException();
        }

        private void AutoCompleteText()
        {
            //throw new NotImplementedException();
            Barcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            //read in the tabel
            string fileName = "DB1.accdb";
            string fullPath;
            fullPath = Path.GetFullPath(fileName);
            DB1_con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + fullPath + "; " + " Persist Security Info = False;";
            DB1_con.Open();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = DB1_con;            
            string query2 = " select Field5 from CallRoll  ";
            command2.CommandText = query2;
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                string ID = reader2.GetString(0);
                collection.Add(ID);
            }
            Barcode.AutoCompleteCustomSource = collection;
            DB1_con.Close();
        }

        //OK button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                DB1_con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = DB1_con;
                command.CommandText = "SELECT * from CallRoll where Field5 = '" + Barcode.Text + "' ";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                int rcv = 1;
                while (reader.Read())
                {
                    count = count + 1;
                    Result_label.Text = reader["Field6"].ToString(); 
                    rcv = int.Parse(reader["Field4"].ToString());
                    //MessageBox.Show(rcv.ToString());
                }
                DB1_con.Close();

                if (count == 1 && rcv == 1)
                {
                    check_out();
                    string remain = getRemainPPL();
                    label2.Text = "Thank you! Enjoy.       " + remain + " people left";
                    label2.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
                    //applause to the last person
                    if (remain.Equals ("0"))
                    {
                        play("cheer.wav");
                    }
                    else{
                        play("Cash Register Cha Ching.wav");
                    }
                }else if (count == 1 && rcv == 0){
                    //MessageBox.Show(" Noooo!!!");
                    //Result_label.Text = "";
                    label2.Text = "Nooooo!!! Second time";
                    play("Windows Ding.wav");
                    label2.ForeColor = System.Drawing.Color.Red;                    
                }else if (count > 1){
                    MessageBox.Show("Duplicated Employee Data ");
                }else{
                    play("Windows Ding.wav");
                    MessageBox.Show("Please Enter a Valid Badge number!");                    
                }
                Barcode.Text = "";                
                update_datagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }            
            Barcode.Focus();
            
        }

        /*
        * returtn remain people
        */
        private string getRemainPPL()
        {
            DB1_con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = DB1_con;
            command.CommandText = "SELECT COUNT (CallRoll.Field4 ) FROM CallRoll where CallRoll.Field4 = 1;";
            OleDbDataReader reader = command.ExecuteReader();
            string ppl = string.Empty;
            while (reader.Read())
            {
               // MessageBox.Show(reader[0].ToString());
                 ppl = reader[0].ToString();
            }
            return ppl;
        }

        private void play(string soundEffect)
        {
            string soundfile = @""+ soundEffect + "";
            byte[] bt = File.ReadAllBytes(soundfile);
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }

        /*
        * set count to 0
        */
        private void check_out()
        {
            DB1_con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = DB1_con;
            string query = "update CallRoll set Field4 = '0' where Field5 = '" + Barcode.Text + "' ";
            //MessageBox.Show(query);
            command.CommandText = query;
            command.ExecuteNonQuery();
            //MessageBox.Show("Data saved !!");
            DB1_con.Close();
            ClientScreen csreen = new ClientScreen(Result_label.Text);
            csreen.Show();
        }

         
        /*
        * Start or Reset button
        * set count to 1
        */
        private void Reset_button_Click(object sender, EventArgs e)
        {
            //setTable("PrintCount", 1);
            setTable("Field4", 1);
            play("Windows Ding.wav");
            //string remain = getRemainPPL();
            //label2.Text = "Thank you! Enjoy.       " + remain + " people left";
            Barcode.Select();
        }

        /*
    // get current clock-in poeple ID list from CTdata
    private void getClockInIdList()
    {
        CTconnection.Open();
        OleDbCommand command = new OleDbCommand();
        command.= CTconnection;
        command.CommandText = "SELECT ClockId from tblPunches where Date = '6/28/17'";
        OleDbDataReader reader = command.ExecuteReader();
        //int count = 0;
        ArrayList EmpList = new ArrayList();
        while (reader.Read())            
        {
            //count = count + 1;
            //EmpList.Add(reader.ToString());
            MessageBox.Show(reader.ToString());
        }
        CTconnection.Close();
    }
        */

        

        /*
        * set flag field to 1 
        */
        private void setTable(string Field, int FieldVal)
        {
            DB1_con.Open();
            for (int i = 1; i <= 100; i++)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DB1_con;
                string query = "update CallRoll set " + Field + " = '" + FieldVal + "' where ID = " + i + " ";
                //MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
            }           
            DB1_con.Close();
            update_datagridview();
        }

        private void tabEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DB1_con.Open();
                DB_con.Text = "Connection Successful";
                DB1_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        /* 
        * press enter on keyboard
        */
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
        * show badge number in barcode number field 
        */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Barcode.Text = row.Cells[0].Value.ToString();
            }
            Barcode.Focus();
        }

        /* 
        * display data on the GridView 
        */
        private void update_datagridview()
        {
            try
            {
                // dispaly people list
                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = DB1_con;
                string query3 = "select Field5, Field6, Field7 from CallRoll where Field4 = 1 order by Field6 Asc ";
                //MessageBox.Show(query3);
                command3.CommandText = query3;
                OleDbDataAdapter da = new OleDbDataAdapter(command3);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                DB1_con.Close();

                // dispaly people who are called
                OleDbCommand command4 = new OleDbCommand();
                command4.Connection = DB1_con;
                string query4 = "select Field5, Field6, Field7 from CallRoll where Field4 = 0 order by Field6 Asc ";
                //MessageBox.Show(query3);
                command4.CommandText = query4;
                OleDbDataAdapter da2 = new OleDbDataAdapter(command4);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView3.DataSource = dt2;
                dataGridView3.AutoResizeColumns();
                DB1_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }// end update datagridview

        private void show_image()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*
        * select employee to display corresponding record in each textBox 
        */
        private void Barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void usDash(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}



