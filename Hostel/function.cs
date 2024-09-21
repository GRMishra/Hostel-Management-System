using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    internal class function
    {
        protected OleDbConnection getConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Hostel_Management\\Hostel_Management_System.accdb";
            return conn; 
        }
        public DataSet getData(String query)
        {
            OleDbConnection conn = getConnection();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query,String msg)
        {
            OleDbConnection conn = getConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
