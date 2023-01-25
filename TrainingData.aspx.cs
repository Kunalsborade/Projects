using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TrainingData : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["add"] == "add")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Successfully Data Submitted !!!')", true);
                Session["add"] = "";
            }
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select distinct stream from main_stream";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DropDownList2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
        }


    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select name from main_stream where stream='" + DropDownList2.SelectedItem.Text + "'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DropDownList1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Main Stream !!!')", true);
        }
        else if (DropDownList1.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select  Stream !!!')", true);
        }
        else
        {
            SqlCommand cmd;
            con.Open();
            string mt = "insert into trainingdata values('" + DropDownList2.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox1.Text + "','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"')";
            cmd = new SqlCommand(mt, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["add"] = "add";
            Response.Redirect("TrainingData.aspx");
        }

    }
}