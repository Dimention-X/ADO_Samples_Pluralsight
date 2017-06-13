using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ASP_Demo
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txt1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = String.Format("select count(*) from Person.Address");
            var i= cmd.ExecuteScalar();
            txt1.Text = i.ToString();
            
        }
    }
}