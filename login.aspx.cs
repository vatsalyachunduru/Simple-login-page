using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace WebApplication10
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=VATSALYA-PC\\SQLEXPRESS;Initial Catalog=ITSYSTEMS;Integrated Security=true";
            //command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select count(*) from users where loginid='" + txtUID.Text + "' and loginpwd='" + txtPWD.Text + "';";
            cmd.Connection = conn;
            //open connection
            conn.Open();
            //Execute command and get single value
            var result = cmd.ExecuteScalar();
            if(Convert.ToInt32(result)==0)
                {
                lblMessage.Text = "Invalid Credentials";
                lblMessage.ForeColor=System.Drawing.Color.Red;
                lblMessage.Visible = true;
            }
            else
            {
                Session["isvalid"] = "Yes";
                Response.Redirect("Home.aspx");

            }

            //Close connection
            conn.Close();



        }
    }
}