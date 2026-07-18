using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internship.Traning
{

    //1.Create UI forms
    //2.Create table in database
    //3.Apply required validations using JS
    //4.Setup connectionstring in web.config file
    //5.Create connection class object in back end file
    //6.Write ado.net code to store data in database
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Register values (@name,@contact,@email,@city,@date)",con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@contact",txtContact.Text);
            cmd.Parameters.AddWithValue("@email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@city",ddlCities.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@date",DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();

            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            ddlCities.SelectedIndex = 0;

            Response.Write("<script>alert('Data saved successfully..!')</script>");

        }
    }
}