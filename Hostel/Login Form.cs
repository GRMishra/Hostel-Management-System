using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hostel
{
    public partial class LoginForm : Form
    {
        public LoginForm()     
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Hostel_Management\\Hostel_Management_System.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignin_Click_1(object sender, EventArgs e)
        {
            String user = txtusername.Text;
            String pwd = txtpassword.Text;

            con.Open();
            String login = "SELECT * FROM LogInTB  where LoginID = '" + txtusername.Text + "' AND  Password = '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
