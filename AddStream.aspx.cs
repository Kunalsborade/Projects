using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCollege : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select distinct stream from main_stream";
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

    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select top 1 cid from college_details order by cid desc";
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
            count = 8001;
        }
        h1.Value = Convert.ToString(count);
        SqlCommand cmd;
        con.Open();
        string mt = "insert into college_details values('" + count + "','" + name.Text + "','" + address.Text + "')";
        cmd = new SqlCommand(mt, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Panel1.Visible = false;
        Panel2.Visible = true;
       

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select distinct name from main_stream where stream='"+DropDownList1.SelectedItem.Text+"'";
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

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "--Select Main Stream--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Main Stream !!!')", true);
        }
        else if (DropDownList2.SelectedItem.Text == "--Select Stream--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Stream !!!')", true);
        }
        else
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select top 1 st from stream order by st desc";
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
                count = 6001;
            }
            SqlCommand cmd;
            con.Open();
             ml = "insert into stream values('"+count+"','" + h1.Value + "','" + name.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox1.Text + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Panel2.Visible = true;
            Panel1.Visible = false;
        }
        
    }
}
