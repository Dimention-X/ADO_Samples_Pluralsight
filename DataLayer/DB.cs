using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                string con = ConfigurationManager.ConnectionStrings["AddConnection"].ToString();
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(con);
                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                return sb.ToString();
            }
        }

        public static int ConnectionTimeOut
        {
            get;
            set;
        }

        public static string ApplicationName
        {
            get;
            set;
        }

        
    }
}
