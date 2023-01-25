using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AddQuestions : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Successfully Data Submitted !!!')", true);
            Session["add"] = "";
        }
        ;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text=="--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Type !!!')", true);
        }
        else
        {

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select top 1 qid from questions order by qid desc";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            int count = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                count = count + 1;
            }
            else
            {
                count = 101;
            }
            SqlCommand cmd;
            con.Open();
            string mt = "insert into questions values('"+count+"','" + DropDownList1.SelectedItem.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            cmd = new SqlCommand(mt, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["add"] = "add";
            Response.Redirect("AddQuestions.aspx");
        }

    }
}