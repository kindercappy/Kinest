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

        public string currProtocol { get => protocol; set => protocol = value; }
        public string currUrl { get => url; set => url = value; }

        public URLOps(string protocol, string url)
        {
            currProtocol = protocol;
            currUrl = url;
        }
        public URLOps()
        {

        }
        /**
         * Method to add url
         * Objective is to add url only if it has not been added before
         **/
        public string AddUrl()
        {
            int checkIfUrlExists = this.checkIfUrlExists();
            if (checkIfUrlExists == 1)
            {
                return "Url already exists";
            }
            int addedOrNot = AddViaSP();
            string messageString = "Cant add URL";
            if (addedOrNot != 0)
            {
                messageString = "URL Added Successfully";
            }
            return messageString;
        }


        private int checkIfUrlExists()
        {
            int urlFoundOrNot = 0;
            List<string> urls = getUrlData();
            foreach (var url in urls)
            {
                if (url == currUrl )
                {
                    urlFoundOrNot = 1;
                }
            }

            return urlFoundOrNot;
        }
        /**
         * Get all the URL data
         **/
        private List<string> getUrlData()
        {
            List<string> urls = new List<string>();
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlDataReader reader;
                cmd.Connection = Common.GetConnection();
                cmd.CommandText = dbInfo.tbSitesStoredSelectSp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    urls.Add((string)reader["url"]);
                }
            }
            //foreach (var url in urls)
            //{

            //    Console.WriteLine(url);
            //}
            //Console.ReadLine();
            return urls;
        }
        /**
         * Get all the matching urls for the url initial supplied
         **/    
        public List<string> getMatchingUrls(string urlInitial)
        {
            List<string> allUrls = new List<string>();
            return allUrls;
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

                SqlParameter sProtocol = new SqlParameter(dbInfo.tbSitesStoredSpColProtocol, currProtocol);
                sProtocol.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sProtocol);

                SqlParameter sUrl = new SqlParameter(dbInfo.tbSitesStoredSpColUrl, currUrl);
                sUrl.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sUrl);

                addedOrNot = cmd.ExecuteNonQuery();
            }
            return addedOrNot;
        }
    }
}
