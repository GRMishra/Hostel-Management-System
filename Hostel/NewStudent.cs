using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Hostel
{
    public partial class NewStudent : Form
    {
        function fn = new function();
        String query;

        public NewStudent()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
            query = "select RoomNo from RoomsTB where roomStatus ='Available'";
            DataSet ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear(); 
            txtMother.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtCollege.Clear();
            comboBoxId.SelectedIndex = -1;
            comboRoomNo.SelectedIndex = -1;
        }

        private void SaveStudentBtn_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text.Length == 10)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text; ;
                String fname = txtFather.Text;
                String mname = txtName.Text;
                String email = txtEmail.Text;
                String paddress = txtAddress.Text;
                String college = txtCollege.Text;
                String idproof = comboBoxId.Text;
                Int64 RoomNo = Int64.Parse(comboRoomNo.Text);

                query = "insert into studentTB (MobileNo,name,Father,Mother,Mail,Address,College,ProofID,RoomNo) values" +
                    " (" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + college + "','" + idproof + "'," + RoomNo + ")";
                fn.setData(query, "Student Registration Successful");
            }
            else
            {
                MessageBox.Show("Invalid Mobile Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*query = "update RoomsTB set Booked='Booked' and RoomNo =" + RoomNo + "";
            fn.setData(query,"saved!!");
            ClearAll();
            */

        }
    }
}

          

        