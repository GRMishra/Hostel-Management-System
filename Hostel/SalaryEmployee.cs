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
    public partial class SalaryEmployee : Form
    {
        function fn = new function();
        String query;
        public SalaryEmployee()
        {
            InitializeComponent();
        }

        private void SalaryEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // EmpID,EMobileNo,EName,EFname,EMname,EmMail,EAdress,EIdProof,Designation
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtmobile.Text!="")
            {
                if (txtmobile.Text.Length == 10)
                {
                    query = "select EName,EmMail,Designation from EmployeeTB where EMobileNo = " + txtmobile.Text + "";
                    DataSet ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        txtname.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtmail.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtdesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                        setDataGrid(Int64.Parse(txtmobile.Text));
                    }
                    else
                    {
                        MessageBox.Show("No Record Exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Mobile Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Enter Some Data..","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void setDataGrid(Int64 mobile)
        {
            query = "select * from SalaryTB where EMobileNo=" + mobile + "";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtmobile.Clear();
            txtname.Clear();
            txtpayment.Clear();
            txtdesignation.Clear();
            txtmail.Clear();
            dataGridView1.DataSource = 0;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if(txtmobile.Text !="" && txtpayment.Text != "")
            {
                query = "select * from SalaryTB where EMobileNo="+Int64.Parse(txtmobile.Text)+" and Fmonth='"+dateTimePicker1.Text+"'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtmobile.Text);
                    String month = dateTimePicker1.Text;
                    Int64 amount = Int64.Parse(txtpayment.Text);
                    query = "insert into SalaryTB values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query,"Salary for month"+dateTimePicker1.Text+ "Paid");
                    clearAll();
                 

                }
                else
                {
                    MessageBox.Show("Payment of " + dateTimePicker1.Text + " Already Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
