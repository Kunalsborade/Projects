using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyProfile : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string uid = Session["id"].ToString();
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select name,mobile,email,ssc,hsc from register where sid='" + uid + "'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                name.Text = ds.Tables[0].Rows[0][0].ToString();
                mobile.Text = ds.Tables[0].Rows[0][1].ToString();
                email.Text = ds.Tables[0].Rows[0][2].ToString();
                ssc.Text = ds.Tables[0].Rows[0][3].ToString();
                hsc.Text = ds.Tables[0].Rows[0][4].ToString();

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string uid = Session["id"].ToString();
        SqlCommand cmd;
        con.Open();
        string mt = "update register set mobile='" + mobile.Text + "',email='" + email.Text + "',ssc='" + ssc.Text + "',hsc='" + hsc.Text + "' where sid='" + uid + "'";
        cmd = new SqlCommand(mt, con);
        cmd.ExecuteNonQuery();
        con.Close();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select name,mobile,email,ssc,hsc from register where sid='" + uid + "'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            name.Text = ds.Tables[0].Rows[0][0].ToString();
            mobile.Text = ds.Tables[0].Rows[0][1].ToString();
            email.Text = ds.Tables[0].Rows[0][2].ToString();
            ssc.Text = ds.Tables[0].Rows[0][3].ToString();
            hsc.Text = ds.Tables[0].Rows[0][4].ToString();

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        mobile.ReadOnly = false;
        email.ReadOnly = false;
        ssc.ReadOnly = false;
        hsc.ReadOnly = false;
    }
}