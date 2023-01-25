using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class ssc_hsc_marks_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Successfully Data Submitted !!!')", true);
            Session["add"] = "";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (course.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "Select Course !!!", true);
        }
        else
        {
            string uid = Session["id"].ToString();
            SqlCommand cmd;
            con.Open();
            string ml = "insert into marks_details values('" + uid + "','" + course.SelectedItem.Text + "','" + subject.Text + "','" + marks.Text + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["add"] = "add";
            Response.Redirect("ssc_hsc_marks_details.aspx");
        }
    }
}