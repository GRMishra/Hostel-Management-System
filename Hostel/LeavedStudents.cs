﻿using System;
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
    public partial class LeavedStudents : Form
    {
        function fn = new function();
        String query;
        public LeavedStudents()
        {
            InitializeComponent();
        }

        private void LeavedStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
            query = "select * from studentTB where LivingStatus ='Not Living'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
