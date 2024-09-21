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
    public partial class AddNewRoom : Form
    {
        function fn = new function();
        String query;
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
            labelRoom.Visible= false;
            labelRoomExist.Visible= false;

            query = "select * from RoomsTB";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            query = "select * from RoomsTB where RoomNo=" + txtRoomNo1.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                String status;

                if (checkBox1.Checked)
                {
                    status = "Available";
                }
                else
                {
                    status = "Not Available";
                }
                labelRoomExist.Visible = false;
                query = "insert into RoomsTB (RoomNo,roomStatus) values (" + txtRoomNo1.Text+",'"+status+"')";
                fn.setData(query,"Room Added");
                AddNewRoom_Load(this, null);
            }
            else
            {
                labelRoomExist.Text = "Room Already Exists";
                labelRoomExist.Visible=true;
            }
        }

        private void SearchRoomBtn_Click(object sender, EventArgs e)
        {
            query = "select * from RoomsTB where RoomNo =" + txtRoomNo2.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                labelRoom.Text = "No Room Exists";
                labelRoom.Visible=true;
                checkBox2.Checked = false;
            }
            else
            {
                labelRoom.Text = "Room Found.";
                labelRoom.Visible=true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes" )
                {
                    checkBox2.Checked=true;
                }
                else
                {
                    checkBox2.Checked=false;
                }
            }
        }

        private void UpdateRoomBtn_Click(object sender, EventArgs e)
        {
            String rstatus;

            if (checkBox2.Checked)
            {
                rstatus = "Available"; 
            }
            else
            {
                rstatus = "Not Available";
            }
            query = "update RoomsTB set roomStatus='" + rstatus+"' where RoomNo ="+txtRoomNo2.Text+" ";
            fn.setData(query, "Details Updated Successfully");
            AddNewRoom_Load(this, null);
        }

        private void DeleteRoomBtn_Click(object sender, EventArgs e)
        {
            if(labelRoom.Text=="Room Found.")
            {
                query = "delete from RoomsTB where RoomNo=" + txtRoomNo2.Text+"";
                fn.setData(query,"Rooms Details Deleted Successfully");
                AddNewRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which Doesnt Exist.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
