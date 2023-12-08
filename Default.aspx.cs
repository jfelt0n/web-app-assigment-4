using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace web_app_assigment_4
{
    public partial class _Default : Page
    {
        public DataTable GetDataFromDataBase()
        {
            DataTable dt = new DataTable();


            string connString = ConfigurationManager.ConnectionStrings["CitizensScienceDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "EXEC spGetAllTheInstitutions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                
            }
            return dt;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            InstitutionTable.DataSource = GetDataFromDataBase();
            InstitutionTable.DataBind();
        }
    }
}