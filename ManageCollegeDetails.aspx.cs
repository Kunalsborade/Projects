using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ManageCollegeDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["delete"] == "delete")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Successfully Deleted !!!')", true);
                Session["delete"] = "";
            }
            else if (Session["update"] == "update")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Successfully Updated !!!')", true);
                Session["update"] = "";
            }
            Panel1.Visible = false;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select s.st,c.cname,s.stream,s.cutoff from college_details c,stream s where c.cid=s.cid";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                
            }
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            HiddenField2.Value= i;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select stream,cutoff from stream where st='"+i+"'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                stream.Text = ds.Tables[0].Rows[0][0].ToString();
                cutoff.Text= ds.Tables[0].Rows[0][1].ToString();
                
                Panel1.Visible = true;
               
            }

        }
        else if (e.CommandName == "del")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            HiddenField2.Value = i;
            if (HiddenField1.Value == "1")
            {
                SqlCommand cmd;
                con.Open();
                string m = "delete from stream where st='" + i + "'";
                cmd = new SqlCommand(m, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Session["delete"] = "delete";
                Response.Redirect("ManageCollegeDetails.aspx");
            }
        }
       

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd;
        con.Open();
        string ml = "update stream set stream='"+stream.Text+"',cutoff='"+cutoff.Text+"' where st='"+HiddenField2.Value+"'";
        cmd = new SqlCommand(ml, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["update"] = "update";
        Response.Redirect("ManageCollegeDetails.aspx");
    }
}