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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtmobile.Text.Length == 10)
            {
                query = "select * from EmployeeTB where EMObileNo = " + txtmobile.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtfather.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmother.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtmail.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtpaddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtuid.Text = ds.Tables[0].Rows[0][6].ToString();
                    comboBoxDesignation.Text = ds.Tables[0].Rows[0][7].ToString();
                    comboBoxWorking.Text = ds.Tables[0].Rows[0][8].ToString();

                }
                else
                {
                    MessageBox.Show("No Record Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid Mobile Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtmobile.Text);
            String name = txtname.Text;
            String fname = txtfather.Text;
            String mname = txtmother.Text;
            String email = txtmail.Text;
            String paddress = txtpaddress.Text;
            String uid = txtuid.Text;  
            String designation = comboBoxDesignation.Text;
            String working = comboBoxWorking.Text;
            // EmpID,EMobileNo,EName,EFname,EMname,EmMail,EAdress,EIdProof,Designation
            query = "update EmployeeTB set EName='"+name+ "',EFname='"+fname+ "',EMname='"+mname+ "',EmMail='"+email+ "',EAdress='"+paddress+ "',EIdProof='"+uid+ "',Designation='"+designation+ "',WorkingStatus='"+working+"' where EMobileNo="+mobile+"";
            fn.setData(query, "Details Updated");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from EmployeeTb where EMobileNo = " + txtmobile.Text + "";
                fn.setData(query, "Student Record Deleted");
                ClearAll();
            }
        }
        private void ClearAll()
        { 
            txtname.Clear();
            txtmobile.Clear();
            txtfather.Clear();
            txtmother.Clear();
            txtmail.Clear();
            txtpaddress.Clear();
            txtuid.Clear();
            comboBoxDesignation.SelectedIndex = -1;
            comboBoxWorking.SelectedIndex = -1;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
