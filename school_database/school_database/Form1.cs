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

namespace school_database
{
    public partial class Form1 : Form
    {
        db mydb = new db();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string fname= textBoxfirst.Text;
            string mname= textBoxmiddle.Text;
            string lname= textBoxlast.Text;
            string dob= textBoxdob.Text;
            string phone= textBoxphone.Text;
            string address= textBoxaddress.Text;
            string state= textBoxstate.Text;
            string emails= textBoxemail.Text;
            try
            {
                mydb.insert(fname, mname, lname, dob, phone, address, state, emails);
                MessageBox.Show("inserted");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            
        }




        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
    public class db {

       public string MyConnectionString = "Server = 127.0.0.1;username= root;password=root;database=student_database;";
        MySqlConnection connection; 
        public void openconnection()
        {
            connection = new MySqlConnection(MyConnectionString);


            try
            {
                connection.Open();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public void closeconnection()
        {

            connection.Close();
        }

        public void insert(string fname, string mname, string lname,string dob,string phone, string address,string state,string emails)
        {
            openconnection();
           
            string query = "INSERT INTO student VALUES(' ','" + fname + "','" + mname + "','" + lname + "','" + dob + "','" + phone + "','" + address + "','" + state + "','" + emails + "')";
            MySqlCommand cmd = new MySqlCommand(query,connection);
            cmd.ExecuteNonQuery();
            
        

            
            closeconnection();


        }
      
    }
}

