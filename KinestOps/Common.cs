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
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public static bool CanConnectToDB()
        {
            return IsServerConnected(connectionString);
        }
    }
}
