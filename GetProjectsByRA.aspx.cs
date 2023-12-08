using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_app_assigment_4
{
    public partial class GetProjectsByRA : System.Web.UI.Page
    {
        public DataTable GetDataFromDatabase()
        {
            DataTable dt = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["CitizensScienceDB"].ToString();
            string idValue = Request.QueryString["Researchid"];


            //looking for inserted parameters
            if (!string.IsNullOrEmpty(idValue))
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Use a query
                    string query = "EXEC spGetAllProjects @Researchid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Researchid", idValue);
                        cmd.ExecuteNonQuery();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            return dt;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  //if no paramters entered return back to research areas web page
            {
                string IDValue = Request.QueryString["Researchid"];
                if (string.IsNullOrEmpty(IDValue))
                {
                    Response.Redirect("GetRAByInstitution.aspx");
                }
                else //if parameters are entered, proceed
                {
                    ProjectsTable.DataSource = GetDataFromDatabase();
                    ProjectsTable.DataBind();
                }
            }
        }
    }
}