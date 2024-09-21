using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            LoginForm fm = new LoginForm();
            fm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelVisible==true)
            {
                hmslabel.Visible = true;
                labelVisible = false;
            }
            else
            {
                hmslabel.Visible = false;
                labelVisible = true;
            }
        }

        private void BtnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent ud = new UpdateDeleteStudent();
            ud.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees();
            sf.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AllStudentsLiving asl = new AllStudentsLiving();
            asl.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            LeavedStudents ls = new LeavedStudents();
            ls.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            NewEmployee ne = new NewEmployee();
            ne.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ade = new UpdateDeleteEmployee();
            ade.Show();
        }

        private void Emppaymentbtn_Click(object sender, EventArgs e)
        {
            SalaryEmployee se = new SalaryEmployee();
            se.Show();
        }

        private void EmpWorkingBtn_Click(object sender, EventArgs e)
        {
            AllEmployeeWorking awe = new AllEmployeeWorking();
            awe.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            LeavedEmployee le = new LeavedEmployee();
            le.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
