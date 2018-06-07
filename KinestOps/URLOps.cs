using KinestInterfaces;
using KinestOps;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinestOps
{
    public class URLOps : IURLOps
    {
        /** <summary>
         * To delegate the URL storage operations
         * </summary>
         **/
        private delegate int StoreUrl();

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
        /** <summary>
         * Method to add URL,
         * Objective is to add URL only if it has not been added before.
         * Will determine if the SQL DB is connectable, if yes it will add the URL in DB
         * or it will store the URL in a JSON file (which later when db comes online will sync the URL's to DB)
         * </summary>
         **/
        public string AddUrl()
        {
            StoreUrl storeUrl;
            int checkIfUrlExists = this.CheckIfUrlExists();
            int addedOrNot = 0;
            if (checkIfUrlExists == 1)
            {
                return Constants.URLExists;
            }
            if (Common.CanConnectToDB())
            {
                storeUrl = new StoreUrl(AddViaSP);
                addedOrNot = storeUrl();
            }
            else
            {
                storeUrl = new StoreUrl(AddToJson);
                addedOrNot = storeUrl();
            }
            string messageString = Constants.URLCantBeAdded;
            if (addedOrNot != 0)
            {
                messageString = Constants.URLAdditionSuccess;
            }
            return messageString;
        }
        /**
         * <summary>
            Add the url via a stored procedure in the suitable table
            </summary>
         **/
        private int AddViaSP()
        {
            if (!Common.CanConnectToDB()) return 0;
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
        /**
         * <summary>
            Add the url to JSON
           </summary>
         **/
        private int AddToJson()
        {
            bool folderCreated = CreateJsonFolder();
            int dataWrittenOrNot = 0;
            if (folderCreated)
            {
                dataWrittenOrNot = WriteDataToJson();
                MessageBox.Show(Constants.FolderCreated);
            }
            return 1;
        }
        private int WriteDataToJson()
        {
            // TODO Implement this functionality of writing data to json file
            int dataWrittenOrNot = 0;

            return dataWrittenOrNot;
        }
        private bool CreateJsonFolder()
        {
            // TODO In the process of implementing this functionality. Created the JSON folder succesfully. Complete the whole func of add a new file for a new url data. FileName: Date-time-seconds-url(regex the url to store it in normal form)
            bool jsonFolderCreated = false;
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent();

            string path = GetJsonDirPath();
            //Return if json folder already exists
            if (Directory.Exists(path)) return true;
            try
            {
                if (!Directory.Exists(path))
                {
                    jsonFolderCreated = true;
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return jsonFolderCreated;
        }

        private string GetJsonDirPath()
        {
            var solutionDirName = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            string path = $@"{solutionDirName}\json";
            return path;
        }

        private int CheckIfUrlExists()
        {
            int urlFoundOrNot = 0;
            IEnumerable<string> urls = GetUrlData();
            if (urls == null)
            {
                return urlFoundOrNot;
            }
            foreach (var url in urls)
            {
                if (url == currUrl)
                {
                    urlFoundOrNot = 1;
                }
            }

            return urlFoundOrNot;
        }
        /**
         * Get all the URL data
         **/
        public List<string> GetUrlData()
        {
            if (!Common.CanConnectToDB()) return null;
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
            return urls;
        }
        /**
         * Get all the matching urls for the url initial supplied
         **/
        public List<string> GetMatchingUrls(string urlInitial)
        {
            if (!Common.CanConnectToDB()) return null;
            List<string> urls = new List<string>();
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlDataReader reader;
                cmd.Connection = Common.GetConnection();
                cmd.CommandText = dbInfo.tbSitesStoredSelectUrlStartingWithSp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sUrlStartsWith = new SqlParameter(dbInfo.tbSitesStoredSpColUrl, urlInitial);
                sUrlStartsWith.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sUrlStartsWith);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    urls.Add((string)reader["url"]);
                }
            }
            return urls;
        }

    }
}
