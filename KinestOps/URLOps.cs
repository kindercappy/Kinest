using KinestOps;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinestOps
{
    public class URLOps
    {
        private string protocol;
        private string url;

        public string Protocol { get => protocol; set => protocol = value; }
        public string Url { get => url; set => url = value; }

        public URLOps(string protocol, string url)
        {
            Protocol = protocol;
            Url = url;
        }
        /**
         * Method to add url
         * Objective is to add url only if it has not been added before
         **/
        public string AddUrl()
        {
            int checkIfUrlExists = GetUrl();
            int addedOrNot = AddViaSP();
            string messageString = "Cant add URL";
            //MessageBox.Show(addedOrNot.ToString());
            if (addedOrNot == 0)
            {
                messageString = "Cant add URL";
            }
            else
            {
                messageString = "URL Added Successfully";
            }

            return messageString;
        }


        private int GetUrl()
        {
            int urlFoundOrNot = 0;


            return urlFoundOrNot;
        }
        private void getUrlData()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlDataReader reader;
                cmd.Connection = Common.GetConnection();
                cmd.CommandText = dbInfo.tbSitesStoredSelectSp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

                MessageBox.Show(reader.ToString());
            }
        }
        /**
         * Add the url via a stored procedure in the suitable table
         **/
        private int AddViaSP()
        {
            int addedOrNot = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.GetConnection();
                cmd.CommandText = dbInfo.tbSitesStoredAddSp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sProtocol = new SqlParameter(dbInfo.tbSitesStoredSpColProtocol, Protocol);
                sProtocol.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sProtocol);

                SqlParameter sUrl = new SqlParameter(dbInfo.tbSitesStoredSpColUrl, Url);
                sUrl.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sUrl);

                addedOrNot = cmd.ExecuteNonQuery();
            }
            return addedOrNot;
        }
    }
}
