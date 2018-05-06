using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinestOps
{
    public class Common
    {
        public static string connectionString = "Data Source =.; Initial Catalog=kinest; Integrated Security = SSPI;";

        public static SqlConnection GetConnection()
        {
            SqlConnection myConnection;
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            //if (myConnection != null && myConnection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Connected");
            //}
            //else
            //{
            //    MessageBox.Show("not connected");
            //}
            return myConnection;
        }
    }
}
