using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_app_assigment_4
{
	public partial class ObservationSubmission : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ShowObservations();
		}
		protected void ShowObservations()
		{
			if (User.Identity.IsAuthenticated)
			{
				Observations.Visible = true;
			}
			else
			{
				Response.Redirect("~/Account/Login.aspx");
			}
		}
		private void AddObservation()
		{
			string userID = HttpContext.Current.User.Identity.GetUserId();	
			if (userID == null)
			{
				string connString = ConfigurationManager.ConnectionStrings["CititzenScienceDB"].ToString();
				using (SqlConnection conn = new SqlConnection(connString)) 
				{ 
					conn.Open();	
					using (SqlCommand cmd = new SqlCommand("spAddObservation", conn))
					{
						cmd.CommandType = System.Data.CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@ObservationDate", Date.Text);
						cmd.Parameters.AddWithValue("@Notes",Notes.Text);
						cmd.Parameters.AddWithValue("@id", userID);

						cmd.ExecuteNonQuery();
					}
				}
			}
		}
		public void Create_Click(object sender, EventArgs e)
		{
			if (Page.IsValid)
			{
				AddObservation();
				Response.Redirect("Observations.aspx");
			}
		}
	}
}