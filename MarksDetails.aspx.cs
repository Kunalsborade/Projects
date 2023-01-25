using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

public partial class MarksDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["id"].ToString();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select apti,maths,eng,ssc,hsc,course from results where uid='" + id + "'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        string[] XPointMember = new string[ds.Tables[0].Columns.Count];
        int[] YPointMember = new int[ds.Tables[0].Columns.Count];
        if (ds.Tables[0].Rows.Count > 0)
        {

            XPointMember[0] = "Apptitude";
            double apti = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString()) / 15;
            int av = Convert.ToInt32(apti * 100);
            YPointMember[0] = av;
            XPointMember[1] = "Maths";
            double maths = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString()) / 15;
            int mv = Convert.ToInt32(maths * 100);
            YPointMember[1] = mv;
            XPointMember[2] = "English";
            double eng = Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString()) / 15;
            int ev = Convert.ToInt32(eng * 100);
            YPointMember[2] = ev;
            XPointMember[3] = "SSC";
            YPointMember[3] = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());
            XPointMember[4] = "HSC";
            YPointMember[4] = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
            Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

            //Setting width of line  
            Chart1.Series[0].BorderWidth = 10;
            //setting Chart type   
            Chart1.Series[0].ChartType = SeriesChartType.Pie;
            Label1.Text = "You can go for " + ds.Tables[0].Rows[0][5].ToString();
        }
        string[] s = ds.Tables[0].Rows[0][5].ToString().Split(',');
        foreach (string word in s)
        {
            SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            string l = "select c.cname,c.address,s.stream,s.cutoff from college_details c,stream s where c.cid=s.cid and s.stream='" + word + "'";
            da1 = new SqlDataAdapter(l, con);
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds1;
                GridView1.DataBind();
            }
        }
    }
}