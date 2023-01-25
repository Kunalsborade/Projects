using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AddStream : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["add"] == "add")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Data Submitted !!!')", true);
                Session["add"] = "";
            }
            
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Main Stream !!!')", true);
        }
        else
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select top 1 id from main_stream order by id desc";
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
                count = 1001;
            }
            SqlCommand cmd;
            con.Open();
            string mt = "insert into main_stream values('" + count + "','" + stream.Text + "','" + DropDownList1.SelectedItem.Text + "','" + features.Text + "')";
            cmd = new SqlCommand(mt, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["add"] = "add";
            Response.Redirect("AddMainStream.aspx");
        }



    }
    

    
}
