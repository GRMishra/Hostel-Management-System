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
    public partial class AllStudentsLiving : Form
    {
        function fn = new function();
        String query;
        public AllStudentsLiving()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStudentsLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 170);
            query = "select * from studentTB where LivingStatus ='Living'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
