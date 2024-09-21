using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hostel
{
    public partial class StudentFees : Form
    {
        function fn = new function();
        String query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void mobnumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(mobnumtxt.Text != "")
            {
                if (mobnumtxt.Text.Length == 10)
                {
                    query = "select name,Mail,RoomNo from studentTB where MobileNo =" + mobnumtxt.Text + "";
                    DataSet ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtMail.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();

                        setDataGrid(Int64.Parse(mobnumtxt.Text));
                    }
                    else
                    {
                        MessageBox.Show("No Record Exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mobile Number Entered is Inavlid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void setDataGrid(Int64 mobile)
        {
            query = "select * from FeesTB where MobileNo=" + mobile + "";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if(mobnumtxt.Text!= "" && txtamt.Text != "")
            {
                query = "select * from FeesTB where MobileNo= " + Int64.Parse(mobnumtxt.Text) + "and Fmonth='"+dateTimePicker1.Text+"'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(mobnumtxt.Text);
                    String month = dateTimePicker1.Text;
                    Int64 amount = Int64.Parse(txtamt.Text);
                    query = "insert into FeesTB values("+mobile+",'"+month+"',"+amount+")";
                    fn.setData(query, "fees Paid");
                    clearAll();

                }
                else
                {
                    MessageBox.Show("No Dues Of " + dateTimePicker1.Text + "Left","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            mobnumtxt.Clear();
            txtName.Clear();
            txtamt.Clear();
            txtRoomNo.Clear();
            txtMail.Clear();
            dataGridView1.DataSource = 0;
        }
    }
}
