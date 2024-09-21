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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Hostel
{
    public partial class UpdateDeleteStudent : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            mobiletxt.Clear();
            txtname.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtMail.Clear();
            txtpaddress.Clear();
            txtcollege.Clear();
            comboBoxId.SelectedIndex = -1;
            txtRNo.Clear();
            comboBoxLiving.SelectedIndex = -1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (mobiletxt.Text.Length == 10)
            {
                query = "select * from studentTB where MobileNo = " + mobiletxt.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtfname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMail.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtpaddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtcollege.Text = ds.Tables[0].Rows[0][6].ToString();
                    comboBoxId.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtRNo.Text = ds.Tables[0].Rows[0][8].ToString();
                    comboBoxLiving.Text = ds.Tables[0].Rows[0][9].ToString();

                }
                else
                {
                    ClearAll();
                    MessageBox.Show("No Record Exists on this mobile number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid Mobile Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(mobiletxt.Text);
            String name = txtname.Text; ;
            String fname = txtfname.Text;
            String mname = txtmname.Text;
            String email = txtMail.Text;
            String paddress = txtpaddress.Text;
            String college = txtcollege.Text;
            String idproof = comboBoxId.Text;
            Int64 RoomNo = Int64.Parse(txtRNo.Text);
            String LivingStatus = comboBoxLiving.Text;

            query = "update studentTB set name = '" + name + "',Father = '" + fname + "',Mother = '" + mname + "',Mail = '" + email + "',Address = '" + paddress + "',College = '" + college + "',ProofID = '" + idproof + "',RoomNo =" + RoomNo + ",LivingStatus = '" + LivingStatus + "' where MobileNo = " + mobile+"";
            fn.setData(query, "Data Updated Successfully");
            ClearAll();
            //query = "update RoomsTB set Booked = '" + LivingStatus+"' where RoomNo = "+RoomNo;
            //fn.setData(query,"Updated");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from studentTB where MobileNo = " + mobiletxt.Text + ""; 
                fn.setData(query, "Student Record Deleted");
                ClearAll();
            }
        }
    }
}
