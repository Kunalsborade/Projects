using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Successfully Registered !!!')", true);
            Session["add"] = "";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da1;
        DataSet ds1 = new DataSet();
        string l = "select uname from register where uname='" + uname.Text + "'";
        da1 = new SqlDataAdapter(l, con);
        da1.Fill(ds1);
        if (ds1.Tables[0].Rows.Count > 0)
        {
            Label1.Visible = true;
        }
        else
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select top 1 sid from register order by sid desc";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            int id = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                id = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                id = id + 1;


            }
            else
            {
                id = 1001;

            }
            SqlCommand cmd;
            con.Open();
            string m = "insert into register values('" + id + "','" + name.Text + "','" + mobile.Text + "','" + email.Text + "','"+ssc.Text+"','"+hsc.Text+"','" + uname.Text + "','" + pass.Text + "')";
            cmd = new SqlCommand(m, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["add"] = "add";
            Response.Redirect("Register.aspx");
        }
    }
}