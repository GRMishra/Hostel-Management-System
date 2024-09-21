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
    public partial class NewEmployee : Form
    {
        function fn = new function();
        String query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Location = new Point(300, 170);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFname.Text != "" && txtMname.Text != "" && txtMail.Text != "" && txtpAddress.Text != "" && txtuid.Text != "" && comboBoxDesignation.SelectedIndex != -1)
            {
                if (txtMobile.Text.Length == 10)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String name = txtName.Text;
                    String fname = txtFname.Text;
                    String mname = txtMname.Text;
                    String email = txtMail.Text;
                    String paddress = txtpAddress.Text;
                    String uid = txtuid.Text;
                    String designation = comboBoxDesignation.Text;

                    query = "insert into EmployeeTB (EMobileNo,EName,EFname,EMname,EmMail,EAdress,EIdProof,Designation) values(" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + uid + "','" + designation + "')";
                    fn.setData(query, "Employee Registered Succesfully");
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Mobile Entered is Incorrect/Invalid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Fill All Required Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
         
            txtName.Clear();
            txtMobile.Clear();
            txtFname.Clear();
            txtMname.Clear();
            txtMail.Clear();
            txtpAddress.Clear();
            txtuid.Clear();
            comboBoxDesignation.SelectedIndex = -1;
        }
      
    }

       
}
