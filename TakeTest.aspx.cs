using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TakeTest : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Password"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            res.Visible = false;
            m1.Visible = true;
            m2.Visible = false;
            m3.Visible = false;
            ca1.Visible = false;
            ca2.Visible = false;
            ca3.Visible = false;
            ca4.Visible = false;
            ca5.Visible = false;
            ca6.Visible = false;
            ca7.Visible = false;
            ca8.Visible = false;
            ca9.Visible = false;
            ca10.Visible = false;
            ca11.Visible = false;
            ca12.Visible = false;
            ca13.Visible = false;
            ca14.Visible = false;
            ca15.Visible = false;
            ca16.Visible = false;
            ca17.Visible = false;
            ca18.Visible = false;
            ca19.Visible = false;
            ca20.Visible = false;
            ca21.Visible = false;
            ca22.Visible = false;
            ca23.Visible = false;
            ca24.Visible = false;
            ca25.Visible = false;
            ca26.Visible = false;
            ca27.Visible = false;
            ca28.Visible = false;
            ca29.Visible = false;
            ca30.Visible = false;
            ca31.Visible = false;
            ca32.Visible = false;
            ca33.Visible = false;
            ca34.Visible = false;
            ca35.Visible = false;
            ca36.Visible = false;
            ca37.Visible = false;
            ca38.Visible = false;
            ca39.Visible = false;
            ca40.Visible = false;
            ca41.Visible = false;
            ca42.Visible = false;
            ca43.Visible = false;
            ca44.Visible = false;
            ca45.Visible = false;
            i1.Visible = false;
            i2.Visible = false;
            i3.Visible = false;
            i4.Visible = false;
            i5.Visible = false;
            i6.Visible = false;
            i7.Visible = false;
            i8.Visible = false;
            i9.Visible = false;
            i10.Visible = false;
            i11.Visible = false;
            i12.Visible = false;
            i13.Visible = false;
            i14.Visible = false;
            i15.Visible = false;
            i16.Visible = false;
            i17.Visible = false;
            i18.Visible = false;
            i19.Visible = false;
            i20.Visible = false;
            i21.Visible = false;
            i22.Visible = false;
            i23.Visible = false;
            i24.Visible = false;
            i25.Visible = false;
            i26.Visible = false;
            i27.Visible = false;
            i28.Visible = false;
            i29.Visible = false;
            i30.Visible = false;
            i31.Visible = false;
            i32.Visible = false;
            i33.Visible = false;
            i34.Visible = false;
            i35.Visible = false;
            i36.Visible = false;
            i37.Visible = false;
            i38.Visible = false;
            i39.Visible = false;
            i40.Visible = false;
            i41.Visible = false;
            i42.Visible = false;
            i43.Visible = false;
            i44.Visible = false;
            i45.Visible = false;
           
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string kl = "select top 15 question,a1,a2,a3,a4,ans from questions where type='Apptitude' order by newid()";
            da = new SqlDataAdapter(kl, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
               
                q1.Text = ds.Tables[0].Rows[0][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o1.Items.Add(ds.Tables[0].Rows[0][i].ToString());
                }
                a1.Text = ds.Tables[0].Rows[0][5].ToString();

                q2.Text = ds.Tables[0].Rows[1][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o2.Items.Add(ds.Tables[0].Rows[1][i].ToString());
                }
                a2.Text = ds.Tables[0].Rows[1][5].ToString();

                q3.Text = ds.Tables[0].Rows[2][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o3.Items.Add(ds.Tables[0].Rows[2][i].ToString());
                }
                a3.Text = ds.Tables[0].Rows[2][5].ToString();



                q4.Text = ds.Tables[0].Rows[3][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o4.Items.Add(ds.Tables[0].Rows[3][i].ToString());
                }
                a4.Text = ds.Tables[0].Rows[3][5].ToString();

                q5.Text = ds.Tables[0].Rows[4][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o5.Items.Add(ds.Tables[0].Rows[4][i].ToString());
                }
                a5.Text = ds.Tables[0].Rows[4][5].ToString();


                q6.Text = ds.Tables[0].Rows[5][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o6.Items.Add(ds.Tables[0].Rows[5][i].ToString());
                }
                a6.Text = ds.Tables[0].Rows[5][5].ToString();

                q7.Text = ds.Tables[0].Rows[6][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o7.Items.Add(ds.Tables[0].Rows[6][i].ToString());
                }
                a7.Text = ds.Tables[0].Rows[6][5].ToString();


                q8.Text = ds.Tables[0].Rows[7][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o8.Items.Add(ds.Tables[0].Rows[7][i].ToString());
                }
                a8.Text = ds.Tables[0].Rows[7][5].ToString();

                q9.Text = ds.Tables[0].Rows[8][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o9.Items.Add(ds.Tables[0].Rows[8][i].ToString());
                }
                a9.Text = ds.Tables[0].Rows[8][5].ToString();

                q10.Text = ds.Tables[0].Rows[9][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o10.Items.Add(ds.Tables[0].Rows[9][i].ToString());
                }
                a10.Text = ds.Tables[0].Rows[9][5].ToString();

                q11.Text = ds.Tables[0].Rows[10][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o11.Items.Add(ds.Tables[0].Rows[10][i].ToString());
                }
                a11.Text = ds.Tables[0].Rows[10][5].ToString();

                q12.Text = ds.Tables[0].Rows[11][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o12.Items.Add(ds.Tables[0].Rows[11][i].ToString());
                }
                a12.Text = ds.Tables[0].Rows[11][5].ToString();

                q13.Text = ds.Tables[0].Rows[12][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o13.Items.Add(ds.Tables[0].Rows[12][i].ToString());
                }
                a13.Text = ds.Tables[0].Rows[12][5].ToString();

                q14.Text = ds.Tables[0].Rows[13][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o14.Items.Add(ds.Tables[0].Rows[13][i].ToString());
                }
                a14.Text = ds.Tables[0].Rows[13][5].ToString();

                q15.Text = ds.Tables[0].Rows[14][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o15.Items.Add(ds.Tables[0].Rows[14][i].ToString());
                }
                a15.Text = ds.Tables[0].Rows[14][5].ToString();




            }
            ds = new DataSet();
             kl = "select top 15 question,a1,a2,a3,a4,ans from questions where type='Maths' order by newid()";
            da = new SqlDataAdapter(kl, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                q16.Text = ds.Tables[0].Rows[0][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o16.Items.Add(ds.Tables[0].Rows[0][i].ToString());
                }
                a16.Text = ds.Tables[0].Rows[0][5].ToString();

                q17.Text = ds.Tables[0].Rows[1][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o17.Items.Add(ds.Tables[0].Rows[1][i].ToString());
                }
                a17.Text = ds.Tables[0].Rows[1][5].ToString();

                q18.Text = ds.Tables[0].Rows[2][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o18.Items.Add(ds.Tables[0].Rows[2][i].ToString());
                }
                a18.Text = ds.Tables[0].Rows[2][5].ToString();



                q19.Text = ds.Tables[0].Rows[3][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o19.Items.Add(ds.Tables[0].Rows[3][i].ToString());
                }
                a19.Text = ds.Tables[0].Rows[3][5].ToString();

                q20.Text = ds.Tables[0].Rows[4][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o20.Items.Add(ds.Tables[0].Rows[4][i].ToString());
                }
                a20.Text = ds.Tables[0].Rows[4][5].ToString();


                q21.Text = ds.Tables[0].Rows[5][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o21.Items.Add(ds.Tables[0].Rows[5][i].ToString());
                }
                a21.Text = ds.Tables[0].Rows[5][5].ToString();

                q22.Text = ds.Tables[0].Rows[6][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o22.Items.Add(ds.Tables[0].Rows[6][i].ToString());
                }
                a22.Text = ds.Tables[0].Rows[6][5].ToString();


                q23.Text = ds.Tables[0].Rows[7][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o23.Items.Add(ds.Tables[0].Rows[7][i].ToString());
                }
                a23.Text = ds.Tables[0].Rows[7][5].ToString();

                q24.Text = ds.Tables[0].Rows[8][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o24.Items.Add(ds.Tables[0].Rows[8][i].ToString());
                }
                a24.Text = ds.Tables[0].Rows[8][5].ToString();

                q25.Text = ds.Tables[0].Rows[9][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o25.Items.Add(ds.Tables[0].Rows[9][i].ToString());
                }
                a25.Text = ds.Tables[0].Rows[9][5].ToString();

                q26.Text = ds.Tables[0].Rows[10][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o26.Items.Add(ds.Tables[0].Rows[10][i].ToString());
                }
                a26.Text = ds.Tables[0].Rows[10][5].ToString();

                q27.Text = ds.Tables[0].Rows[11][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o27.Items.Add(ds.Tables[0].Rows[11][i].ToString());
                }
                a27.Text = ds.Tables[0].Rows[11][5].ToString();

                q28.Text = ds.Tables[0].Rows[12][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o28.Items.Add(ds.Tables[0].Rows[12][i].ToString());
                }
                a28.Text = ds.Tables[0].Rows[12][5].ToString();

                q29.Text = ds.Tables[0].Rows[13][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o29.Items.Add(ds.Tables[0].Rows[13][i].ToString());
                }
                a29.Text = ds.Tables[0].Rows[13][5].ToString();

                q30.Text = ds.Tables[0].Rows[14][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o30.Items.Add(ds.Tables[0].Rows[14][i].ToString());
                }
                a30.Text = ds.Tables[0].Rows[14][5].ToString();




            }
            ds = new DataSet();
            kl = "select top 15 question,a1,a2,a3,a4,ans from questions where type='English' order by newid()";
            da = new SqlDataAdapter(kl, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                q31.Text = ds.Tables[0].Rows[0][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o31.Items.Add(ds.Tables[0].Rows[0][i].ToString());
                }
                a31.Text = ds.Tables[0].Rows[0][5].ToString();

                q32.Text = ds.Tables[0].Rows[1][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o32.Items.Add(ds.Tables[0].Rows[1][i].ToString());
                }
                a32.Text = ds.Tables[0].Rows[1][5].ToString();

                q33.Text = ds.Tables[0].Rows[2][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o33.Items.Add(ds.Tables[0].Rows[2][i].ToString());
                }
                a33.Text = ds.Tables[0].Rows[2][5].ToString();



                q34.Text = ds.Tables[0].Rows[3][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o34.Items.Add(ds.Tables[0].Rows[3][i].ToString());
                }
                a34.Text = ds.Tables[0].Rows[3][5].ToString();

                q35.Text = ds.Tables[0].Rows[4][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o35.Items.Add(ds.Tables[0].Rows[4][i].ToString());
                }
                a35.Text = ds.Tables[0].Rows[4][5].ToString();


                q36.Text = ds.Tables[0].Rows[5][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o36.Items.Add(ds.Tables[0].Rows[5][i].ToString());
                }
                a36.Text = ds.Tables[0].Rows[5][5].ToString();

                q37.Text = ds.Tables[0].Rows[6][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o37.Items.Add(ds.Tables[0].Rows[6][i].ToString());
                }
                a37.Text = ds.Tables[0].Rows[6][5].ToString();


                q38.Text = ds.Tables[0].Rows[7][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o38.Items.Add(ds.Tables[0].Rows[7][i].ToString());
                }
                a38.Text = ds.Tables[0].Rows[7][5].ToString();

                q39.Text = ds.Tables[0].Rows[8][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o39.Items.Add(ds.Tables[0].Rows[8][i].ToString());
                }
                a39.Text = ds.Tables[0].Rows[8][5].ToString();

                q40.Text = ds.Tables[0].Rows[9][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o40.Items.Add(ds.Tables[0].Rows[9][i].ToString());
                }
                a40.Text = ds.Tables[0].Rows[9][5].ToString();

                q41.Text = ds.Tables[0].Rows[10][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o41.Items.Add(ds.Tables[0].Rows[10][i].ToString());
                }
                a41.Text = ds.Tables[0].Rows[10][5].ToString();

                q42.Text = ds.Tables[0].Rows[11][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o42.Items.Add(ds.Tables[0].Rows[11][i].ToString());
                }
                a42.Text = ds.Tables[0].Rows[11][5].ToString();

                q43.Text = ds.Tables[0].Rows[12][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o43.Items.Add(ds.Tables[0].Rows[12][i].ToString());
                }
                a43.Text = ds.Tables[0].Rows[12][5].ToString();

                q44.Text = ds.Tables[0].Rows[13][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o44.Items.Add(ds.Tables[0].Rows[13][i].ToString());
                }
                a44.Text = ds.Tables[0].Rows[13][5].ToString();

                q45.Text = ds.Tables[0].Rows[14][0].ToString();
                for (int i = 1; i < 5; i++)
                {
                    o45.Items.Add(ds.Tables[0].Rows[14][i].ToString());
                }
                a45.Text = ds.Tables[0].Rows[14][5].ToString();




            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        m1.Visible = false;
        m2.Visible = true;
        m3.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        m3.Visible = true;
        m1.Visible = false;
        m2.Visible = false;
    }

    protected void LinkButton34_Click(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        m1.Visible = true;
        m2.Visible = false;
        m3.Visible = false;

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        m1.Visible = false;
        m2.Visible = true;
        m3.Visible = false;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        m1.Visible = false;
        m2.Visible = false;
        m3.Visible = true;
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        m1.Visible = true;
        m2.Visible = false;
        m3.Visible = false;
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        m1.Visible = false;
        m2.Visible = true;
        m3.Visible = false;

    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        m1.Visible = false;
        m2.Visible = false;
        m3.Visible = true;
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        m1.Visible = true;
        m2.Visible = false;
        m3.Visible = false;
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        if (Hidden1.Value == "1")
        {
            int count = 0, maths = 0, eng = 0, ua = 0, um = 0, ue = 0;
            if (o1.SelectedIndex>-1)
            {
                ua = ua + 1;
                if (a1.Text.Equals(o1.SelectedItem.Text))
                {
                    count = count + 1;

                    i1.ImageUrl = "img\\yes.jpg";
                    i1.Visible = true;
                    ca1.Visible = true;
                }
                else
                {

                    i1.ImageUrl = "img\\no.jpg";
                    i1.Visible = true;
                    ca1.Visible = true;
                }
            }
            else
            {

                i1.ImageUrl = "img\\no.jpg";
                i1.Visible = true;
                ca1.Visible = true;
            }
            if (o2.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a2.Text.Equals(o2.SelectedItem.Text))
                {
                    count = count + 1;

                    i2.ImageUrl = "img\\yes.jpg";
                    i2.Visible = true;
                    ca2.Visible = true;
                }
                else
                {
                    i2.ImageUrl = "img\\no.jpg";
                    i2.Visible = true;
                    ca2.Visible = true;
                }
            }
            else
            {
                i2.ImageUrl = "img\\no.jpg";
                i2.Visible = true;
                ca2.Visible = true;
            }
            if (o3.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a3.Text.Equals(o3.SelectedItem.Text))
                {
                    count = count + 1;

                    i3.ImageUrl = "img\\yes.jpg";
                    i3.Visible = true;
                    ca3.Visible = true;
                }
                else
                {
                    i3.ImageUrl = "img\\no.jpg";
                    i3.Visible = true;
                    ca3.Visible = true;
                }
            }
            else
            {
                i3.ImageUrl = "img\\no.jpg";
                i3.Visible = true;
                ca3.Visible = true;
            }
            if (o4.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a4.Text.Equals(o4.SelectedItem.Text))
                {
                    count = count + 1;

                    i4.ImageUrl = "img\\yes.jpg";
                    i4.Visible = true;
                    ca4.Visible = true;
                }
                else
                {
                    i4.ImageUrl = "img\\no.jpg";
                    i4.Visible = true;
                    ca4.Visible = true;
                }
            }
            else
            {
                i4.ImageUrl = "img\\no.jpg";
                i4.Visible = true;
                ca4.Visible = true;
            }
            if (o5.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a5.Text.Equals(o5.SelectedItem.Text))
                {
                    count = count + 1;

                    i5.ImageUrl = "img\\yes.jpg";
                    i5.Visible = true;
                    ca5.Visible = true;
                }
                else
                {
                    i5.ImageUrl = "img\\no.jpg";
                    i5.Visible = true;
                    ca5.Visible = true;
                }
            }
            else
            {
                i5.ImageUrl = "img\\no.jpg";
                i5.Visible = true;
                ca5.Visible = true;
            }
            if (o6.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a6.Text.Equals(o6.SelectedItem.Text))
                {
                    count = count + 1;

                    i6.ImageUrl = "img\\yes.jpg";
                    i6.Visible = true;
                    ca6.Visible = true;
                }
                else
                {
                    i6.ImageUrl = "img\\no.jpg";
                    i6.Visible = true;
                    ca6.Visible = true;
                }
            }
            else
            {
                i6.ImageUrl = "img\\no.jpg";
                i6.Visible = true;
                ca6.Visible = true;
            }
            if (o7.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a7.Text.Equals(o7.SelectedItem.Text))
                {
                    count = count + 1;

                    i7.ImageUrl = "img\\yes.jpg";
                    i7.Visible = true;
                    ca7.Visible = true;
                }
                else
                {
                    i7.ImageUrl = "img\\no.jpg";
                    i7.Visible = true;
                    ca7.Visible = true;
                }
            }
            else
            {
                i7.ImageUrl = "img\\no.jpg";
                i7.Visible = true;
                ca7.Visible = true;
            }
            if (o8.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a8.Text.Equals(o8.SelectedItem.Text))
                {
                    count = count + 1;

                    i8.ImageUrl = "img\\yes.jpg";
                    i8.Visible = true;
                    ca8.Visible = true;
                }
                else
                {
                    i8.ImageUrl = "img\\no.jpg";
                    i8.Visible = true;
                    ca8.Visible = true;
                }
            }
            else
            {
                i8.ImageUrl = "img\\no.jpg";
                i8.Visible = true;
                ca8.Visible = true;
            }
            if (o9.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a9.Text.Equals(o9.SelectedItem.Text))
                {
                    count = count + 1;

                    i9.ImageUrl = "img\\yes.jpg";
                    i9.Visible = true;
                    ca9.Visible = true;
                }
                else
                {
                    i9.ImageUrl = "img\\no.jpg";
                    i9.Visible = true;
                    ca9.Visible = true;
                }
            }
            else
            {
                i9.ImageUrl = "img\\no.jpg";
                i9.Visible = true;
                ca9.Visible = true;
            }
            if (o10.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a10.Text.Equals(o10.SelectedItem.Text))
                {
                    count = count + 1;

                    i10.ImageUrl = "img\\yes.jpg";
                    i10.Visible = true;
                    ca10.Visible = true;
                }
                else
                {
                    i10.ImageUrl = "img\\no.jpg";
                    i10.Visible = true;
                    ca10.Visible = true;
                }
            }
            else
            {
                i10.ImageUrl = "img\\no.jpg";
                i10.Visible = true;
                ca10.Visible = true;
            }
            if (o11.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a11.Text.Equals(o11.SelectedItem.Text))
                {
                    count = count + 1;

                    i11.ImageUrl = "img\\yes.jpg";
                    i11.Visible = true;
                    ca11.Visible = true;
                }
                else
                {
                    i11.ImageUrl = "img\\no.jpg";
                    i11.Visible = true;
                    ca11.Visible = true;
                }
            }
            else
            {
                i11.ImageUrl = "img\\no.jpg";
                i11.Visible = true;
                ca11.Visible = true;
            }
            if (o12.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a12.Text.Equals(o12.SelectedItem.Text))
                {
                    count = count + 1;

                    i12.ImageUrl = "img\\yes.jpg";
                    i12.Visible = true;
                    ca12.Visible = true;
                }
                else
                {
                    i12.ImageUrl = "img\\no.jpg";
                    i12.Visible = true;
                    ca12.Visible = true;
                }
            }
            else
            {
                i12.ImageUrl = "img\\no.jpg";
                i12.Visible = true;
                ca12.Visible = true;
            }
            if (o13.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a13.Text.Equals(o13.SelectedItem.Text))
                {
                    count = count + 1;

                    i13.ImageUrl = "img\\yes.jpg";
                    i13.Visible = true;
                    ca13.Visible = true;
                }
                else
                {
                    i13.ImageUrl = "img\\no.jpg";
                    i13.Visible = true;
                    ca13.Visible = true;
                }
            }
            else
            {
                i13.ImageUrl = "img\\no.jpg";
                i13.Visible = true;
                ca13.Visible = true;
            }
            if (o14.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a14.Text.Equals(o14.SelectedItem.Text))
                {
                    count = count + 1;

                    i14.ImageUrl = "img\\yes.jpg";
                    i14.Visible = true;
                    ca14.Visible = true;
                }
                else
                {
                    i14.ImageUrl = "img\\no.jpg";
                    i14.Visible = true;
                    ca14.Visible = true;
                }
            }
            else
            {
                i14.ImageUrl = "img\\no.jpg";
                i14.Visible = true;
                ca14.Visible = true;
            }
            if (o15.SelectedIndex > -1)
            {
                ua = ua + 1;
                if (a15.Text.Equals(o15.SelectedItem.Text))
                {
                    count = count + 1;

                    i15.ImageUrl = "img\\yes.jpg";
                    i15.Visible = true;
                    ca15.Visible = true;
                }
                else
                {
                    i15.ImageUrl = "img\\no.jpg";
                    i15.Visible = true;
                    ca15.Visible = true;
                }
            }
            else
            {
                i15.ImageUrl = "img\\no.jpg";
                i15.Visible = true;
                ca15.Visible = true;
            }

            if (o16.SelectedIndex > -1)
            {
                um = um + 1;
                if (a16.Text.Equals(o16.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i16.ImageUrl = "img\\yes.jpg";
                    i16.Visible = true;
                    ca16.Visible = true;
                }
                else
                {
                    i16.ImageUrl = "img\\no.jpg";
                    i16.Visible = true;
                    ca16.Visible = true;
                }
            }
            else
            {
                i16.ImageUrl = "img\\no.jpg";
                i16.Visible = true;
                ca16.Visible = true;
            }
            if (o17.SelectedIndex > -1)
            {
                um = um + 1;
                if (a17.Text.Equals(o17.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i17.ImageUrl = "img\\yes.jpg";
                    i17.Visible = true;
                    ca17.Visible = true;
                }
                else
                {
                    i17.ImageUrl = "img\\no.jpg";
                    i17.Visible = true;
                    ca17.Visible = true;
                }
            }
            else
            {
                i17.ImageUrl = "img\\no.jpg";
                i17.Visible = true;
                ca17.Visible = true;
            }
            if (o18.SelectedIndex > -1)
            {
                um = um + 1;
                if (a18.Text.Equals(o18.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i18.ImageUrl = "img\\yes.jpg";
                    i18.Visible = true;
                    ca18.Visible = true;
                }
                else
                {
                    i18.ImageUrl = "img\\no.jpg";
                    i18.Visible = true;
                    ca18.Visible = true;
                }
            }
            else
            {
                i18.ImageUrl = "img\\no.jpg";
                i18.Visible = true;
                ca18.Visible = true;
            }
            if (o19.SelectedIndex > -1)
            {
                um = um + 1;
                if (a19.Text.Equals(o19.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i19.ImageUrl = "img\\yes.jpg";
                    i19.Visible = true;
                    ca19.Visible = true;
                }
                else
                {
                    i19.ImageUrl = "img\\no.jpg";
                    i19.Visible = true;
                    ca19.Visible = true;
                }
            }
            else
            {
                i19.ImageUrl = "img\\no.jpg";
                i19.Visible = true;
                ca19.Visible = true;
            }
            if (o20.SelectedIndex > -1)
            {
                um = um + 1;
                if (a20.Text.Equals(o20.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i20.ImageUrl = "img\\yes.jpg";
                    i20.Visible = true;
                    ca20.Visible = true;
                }
                else
                {
                    i20.ImageUrl = "img\\no.jpg";
                    i20.Visible = true;
                    ca20.Visible = true;
                }
            }
            else
            {
                i20.ImageUrl = "img\\no.jpg";
                i20.Visible = true;
                ca20.Visible = true;
            }
            if (o21.SelectedIndex > -1)
            {
                um = um + 1;
                if (a21.Text.Equals(o21.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i21.ImageUrl = "img\\yes.jpg";
                    i21.Visible = true;
                    ca21.Visible = true;
                }
                else
                {
                    i21.ImageUrl = "img\\no.jpg";
                    i21.Visible = true;
                    ca21.Visible = true;
                }
            }
            else
            {
                i21.ImageUrl = "img\\no.jpg";
                i21.Visible = true;
                ca21.Visible = true;
            }
            if (o22.SelectedIndex > -1)
            {
                um = um + 1;
                if (a22.Text.Equals(o22.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i22.ImageUrl = "img\\yes.jpg";
                    i22.Visible = true;
                    ca22.Visible = true;
                }
                else
                {
                    i22.ImageUrl = "img\\no.jpg";
                    i22.Visible = true;
                    ca22.Visible = true;
                }
            }
            else
            {
                i22.ImageUrl = "img\\no.jpg";
                i22.Visible = true;
                ca22.Visible = true;
            }
            if (o23.SelectedIndex > -1)
            {
                um = um + 1;
                if (a23.Text.Equals(o23.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i23.ImageUrl = "img\\yes.jpg";
                    i23.Visible = true;
                    ca23.Visible = true;
                }
                else
                {
                    i23.ImageUrl = "img\\no.jpg";
                    i23.Visible = true;
                    ca23.Visible = true;
                }
            }
            else
            {
                i23.ImageUrl = "img\\no.jpg";
                i23.Visible = true;
                ca23.Visible = true;
            }
            if (o24.SelectedIndex > -1)
            {
                um = um + 1;
                if (a24.Text.Equals(o24.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i24.ImageUrl = "img\\yes.jpg";
                    i24.Visible = true;
                    ca24.Visible = true;
                }
                else
                {
                    i24.ImageUrl = "img\\no.jpg";
                    i24.Visible = true;
                    ca24.Visible = true;
                }
            }
            else
            {
                i24.ImageUrl = "img\\no.jpg";
                i24.Visible = true;
                ca24.Visible = true;
            }
            if (o25.SelectedIndex > -1)
            {
                um = um + 1;
                if (a25.Text.Equals(o25.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i25.ImageUrl = "img\\yes.jpg";
                    i25.Visible = true;
                    ca25.Visible = true;
                }
                else
                {
                    i25.ImageUrl = "img\\no.jpg";
                    i25.Visible = true;
                    ca25.Visible = true;
                }
            }
            else
            {
                i25.ImageUrl = "img\\no.jpg";
                i25.Visible = true;
                ca25.Visible = true;
            }
            if (o26.SelectedIndex > -1)
            {
                um = um + 1;
                if (a26.Text.Equals(o21.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i26.ImageUrl = "img\\yes.jpg";
                    i26.Visible = true;
                    ca26.Visible = true;
                }
                else
                {
                    i26.ImageUrl = "img\\no.jpg";
                    i26.Visible = true;
                    ca26.Visible = true;
                }
            }
            else
            {
                i26.ImageUrl = "img\\no.jpg";
                i26.Visible = true;
                ca26.Visible = true;
            }
            if (o27.SelectedIndex > -1)
            {
                um = um + 1;
                if (a27.Text.Equals(o27.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i27.ImageUrl = "img\\yes.jpg";
                    i27.Visible = true;
                    ca27.Visible = true;
                }
                else
                {
                    i27.ImageUrl = "img\\no.jpg";
                    i27.Visible = true;
                    ca27.Visible = true;
                }
            }
            else
            {
                i27.ImageUrl = "img\\no.jpg";
                i27.Visible = true;
                ca27.Visible = true;
            }
            if (o28.SelectedIndex > -1)
            {
                um = um + 1;
                if (a28.Text.Equals(o28.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i28.ImageUrl = "img\\yes.jpg";
                    i28.Visible = true;
                    ca28.Visible = true;
                }
                else
                {
                    i28.ImageUrl = "img\\no.jpg";
                    i28.Visible = true;
                    ca28.Visible = true;
                }
            }
            else
            {
                i28.ImageUrl = "img\\no.jpg";
                i28.Visible = true;
                ca28.Visible = true;
            }
            if (o29.SelectedIndex > -1)
            {
                um = um + 1;
                if (a29.Text.Equals(o29.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i29.ImageUrl = "img\\yes.jpg";
                    i29.Visible = true;
                    ca29.Visible = true;
                }
                else
                {
                    i29.ImageUrl = "img\\no.jpg";
                    i29.Visible = true;
                    ca29.Visible = true;
                }
            }
            else
            {
                i29.ImageUrl = "img\\no.jpg";
                i29.Visible = true;
                ca29.Visible = true;
            }
            if (o30.SelectedIndex > -1)
            {
                um = um + 1;
                if (a30.Text.Equals(o30.SelectedItem.Text))
                {
                    maths = maths + 1;

                    i30.ImageUrl = "img\\yes.jpg";
                    i30.Visible = true;
                    ca30.Visible = true;
                }
                else
                {
                    i30.ImageUrl = "img\\no.jpg";
                    i30.Visible = true;
                    ca30.Visible = true;
                }
            }
            else
            {
                i30.ImageUrl = "img\\no.jpg";
                i30.Visible = true;
                ca30.Visible = true;
            }
            if (o31.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a31.Text.Equals(o31.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i31.ImageUrl = "img\\yes.jpg";
                    i31.Visible = true;
                    ca31.Visible = true;
                }
                else
                {
                    i31.ImageUrl = "img\\no.jpg";
                    i31.Visible = true;
                    ca31.Visible = true;
                }
            }
            else
            {
                i31.ImageUrl = "img\\no.jpg";
                i31.Visible = true;
                ca31.Visible = true;
            }
            if (o32.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a32.Text.Equals(o32.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i32.ImageUrl = "img\\yes.jpg";
                    i32.Visible = true;
                    ca32.Visible = true;
                }
                else
                {
                    i32.ImageUrl = "img\\no.jpg";
                    i32.Visible = true;
                    ca32.Visible = true;
                }
            }
            else
            {
                i32.ImageUrl = "img\\no.jpg";
                i32.Visible = true;
                ca32.Visible = true;
            }
            if (o33.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a33.Text.Equals(o33.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i33.ImageUrl = "img\\yes.jpg";
                    i33.Visible = true;
                    ca33.Visible = true;
                }
                else
                {
                    i33.ImageUrl = "img\\no.jpg";
                    i33.Visible = true;
                    ca33.Visible = true;
                }
            }
            else
            {
                i33.ImageUrl = "img\\no.jpg";
                i33.Visible = true;
                ca33.Visible = true;
            }
            if (o34.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a34.Text.Equals(o34.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i34.ImageUrl = "img\\yes.jpg";
                    i34.Visible = true;
                    ca34.Visible = true;
                }
                else
                {
                    i34.ImageUrl = "img\\no.jpg";
                    i34.Visible = true;
                    ca34.Visible = true;
                }
            }
            else
            {
                i34.ImageUrl = "img\\no.jpg";
                i34.Visible = true;
                ca34.Visible = true;
            }
            if (o35.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a35.Text.Equals(o35.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i35.ImageUrl = "img\\yes.jpg";
                    i35.Visible = true;
                    ca35.Visible = true;
                }
                else
                {
                    i35.ImageUrl = "img\\no.jpg";
                    i35.Visible = true;
                    ca35.Visible = true;
                }
            }
            else
            {
                i35.ImageUrl = "img\\no.jpg";
                i35.Visible = true;
                ca35.Visible = true;
            }
            if (o36.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a36.Text.Equals(o36.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i36.ImageUrl = "img\\yes.jpg";
                    i36.Visible = true;
                    ca36.Visible = true;
                }
                else
                {
                    i36.ImageUrl = "img\\no.jpg";
                    i36.Visible = true;
                    ca36.Visible = true;
                }
            }
            else
            {
                i36.ImageUrl = "img\\no.jpg";
                i36.Visible = true;
                ca36.Visible = true;
            }
            if (o37.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a37.Text.Equals(o37.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i37.ImageUrl = "img\\yes.jpg";
                    i37.Visible = true;
                    ca37.Visible = true;
                }
                else
                {
                    i37.ImageUrl = "img\\no.jpg";
                    i37.Visible = true;
                    ca37.Visible = true;
                }
            }
            else
            {
                i37.ImageUrl = "img\\no.jpg";
                i37.Visible = true;
                ca37.Visible = true;
            }
            if (o38.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a38.Text.Equals(o38.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i38.ImageUrl = "img\\yes.jpg";
                    i38.Visible = true;
                    ca38.Visible = true;
                }
                else
                {
                    i38.ImageUrl = "img\\no.jpg";
                    i38.Visible = true;
                    ca38.Visible = true;
                }
            }
            else
            {
                i38.ImageUrl = "img\\no.jpg";
                i38.Visible = true;
                ca38.Visible = true;
            }
            if (o39.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a39.Text.Equals(o39.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i39.ImageUrl = "img\\yes.jpg";
                    i39.Visible = true;
                    ca39.Visible = true;
                }
                else
                {
                    i39.ImageUrl = "img\\no.jpg";
                    i39.Visible = true;
                    ca39.Visible = true;
                }
            }
            else
            {
                i39.ImageUrl = "img\\no.jpg";
                i39.Visible = true;
                ca39.Visible = true;
            }
            if (o40.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a40.Text.Equals(o40.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i40.ImageUrl = "img\\yes.jpg";
                    i40.Visible = true;
                    ca40.Visible = true;
                }
                else
                {
                    i40.ImageUrl = "img\\no.jpg";
                    i40.Visible = true;
                    ca40.Visible = true;
                }
            }
            else
            {
                i40.ImageUrl = "img\\no.jpg";
                i40.Visible = true;
                ca40.Visible = true;
            }
            if (o41.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a41.Text.Equals(o41.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i41.ImageUrl = "img\\yes.jpg";
                    i41.Visible = true;
                    ca41.Visible = true;
                }
                else
                {
                    i41.ImageUrl = "img\\no.jpg";
                    i41.Visible = true;
                    ca41.Visible = true;
                }
            }
            else
            {
                i41.ImageUrl = "img\\no.jpg";
                i41.Visible = true;
                ca41.Visible = true;
            }
            if (o42.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a42.Text.Equals(o42.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i42.ImageUrl = "img\\yes.jpg";
                    i42.Visible = true;
                    ca42.Visible = true;
                }
                else
                {
                    i42.ImageUrl = "img\\no.jpg";
                    i42.Visible = true;
                    ca42.Visible = true;
                }
            }
            else
            {
                i42.ImageUrl = "img\\no.jpg";
                i42.Visible = true;
                ca42.Visible = true;
            }
            if (o43.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a43.Text.Equals(o43.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i43.ImageUrl = "img\\yes.jpg";
                    i43.Visible = true;
                    ca43.Visible = true;
                }
                else
                {
                    i43.ImageUrl = "img\\no.jpg";
                    i43.Visible = true;
                    ca43.Visible = true;
                }
            }
            else
            {
                i43.ImageUrl = "img\\no.jpg";
                i43.Visible = true;
                ca43.Visible = true;
            }
            if (o44.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a44.Text.Equals(o44.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i44.ImageUrl = "img\\yes.jpg";
                    i44.Visible = true;
                    ca44.Visible = true;
                }
                else
                {
                    i44.ImageUrl = "img\\no.jpg";
                    i44.Visible = true;
                    ca44.Visible = true;
                }
            }
            else
            {
                i44.ImageUrl = "img\\no.jpg";
                i44.Visible = true;
                ca44.Visible = true;
            }
            if (o45.SelectedIndex > -1)
            {
                ue = ue + 1;
                if (a45.Text.Equals(o45.SelectedItem.Text))
                {
                    eng = eng + 1;

                    i45.ImageUrl = "img\\yes.jpg";
                    i45.Visible = true;
                    ca45.Visible = true;
                }
                else
                {
                    i45.ImageUrl = "img\\no.jpg";
                    i45.Visible = true;
                    ca45.Visible = true;
                }


            }
            else
            {
                i45.ImageUrl = "img\\no.jpg";
                i45.Visible = true;
                ca45.Visible = true;
            }
            int t = 15;
            score.Text = Convert.ToString(count);
            total.Text = Convert.ToString(t);
            tq.Text = Convert.ToString(t);
            aq.Text = Convert.ToString(ua);
            uq.Text = Convert.ToString(t - ua);
            score1.Text = Convert.ToString(maths);
            total1.Text = Convert.ToString(t);
            tq1.Text = Convert.ToString(t);
            aq1.Text = Convert.ToString(um);
            uq1.Text = Convert.ToString(t - um);
            score2.Text = Convert.ToString(eng);
            total2.Text = Convert.ToString(t);
            tq2.Text = Convert.ToString(t);
            aq2.Text = Convert.ToString(ue);
            uq2.Text = Convert.ToString(t - ue);
           
            string uid = Session["id"].ToString();
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select ssc,hsc from register where sid='" + uid + "'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            string ssc = "", hsc = "";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ssc = ds.Tables[0].Rows[0][0].ToString();
                hsc = ds.Tables[0].Rows[0][1].ToString();
            }
            Label27.Text = "You can go for <br />";
            for (int i = 0; i < 3; i++)
            {
                string resu = prediction(ssc, hsc,HiddenField1.Value);
                HiddenField1.Value += resu + ",";
                Label27.Text += resu + "<br/>";
            }
            SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            string tm = "select uid from results where uid='" + uid + "'";
            da1 = new SqlDataAdapter(tm, con);
            da1.Fill(ds1);
            SqlCommand cmd;
            con.Open();
            string m = "";
            HiddenField1.Value = HiddenField1.Value.TrimEnd(',');
            if (ds1.Tables[0].Rows.Count > 0)
            {
                m = "update results set apti='" + score.Text + "',maths='" + score1.Text + "',eng='" + score2.Text + "',ssc='" + ssc + "',hsc='" + hsc + "',course='" + HiddenField1.Value + "' where uid='" + uid + "'";
            }
            else
            {
                m = "insert into results values('" + uid + "','" + score.Text + "','" + score1.Text + "','" + score2.Text + "','" + ssc + "','" + hsc + "','" + HiddenField1.Value + "')";
            }
            cmd = new SqlCommand(m, con);
            cmd.ExecuteNonQuery();
            con.Close();
            res.Visible = true;
            m1.Visible = true;
            m2.Visible = false;
            m3.Visible = false;


        }

    }
    string prediction(string ssc,string hsc,string res)
    {

        


        DataTable table = new DataTable();
        table.Columns.Add("Stream");
        table.Columns.Add("Aptitude", typeof(double));
        table.Columns.Add("Maths", typeof(double));
        table.Columns.Add("English", typeof(double));
        table.Columns.Add("SSC", typeof(double));
        table.Columns.Add("HSC", typeof(double));
        table.Columns.Add("sm1", typeof(double));
        table.Columns.Add("sm2", typeof(double));
        table.Columns.Add("sm3", typeof(double));
        table.Columns.Add("hm1", typeof(double));
        table.Columns.Add("hm2", typeof(double));
        table.Columns.Add("hm3", typeof(double));
        string str = "";
       
            str = "select mstream,apti,maths,eng,ssc,hsc,sscm1,sscm2,sscm3,hscm1,hscm2,hscm3 from trainingdata";
       if(res!="")
        {
            res = res.TrimEnd(',');
            str=str.TrimEnd('"');
            str += " where";
            string[] s = res.Split(',');
            foreach (string word in s)
            {
                str += " mstream<>'" + word + "' and";
            }
            char[] MyChar = { 'a', 'n', 'd'};
            for (int j = 0; j < MyChar.Length; j++)
            {
                str= str.TrimEnd(MyChar);
            }
            
        }
            SqlDataAdapter da = new SqlDataAdapter(str, con);
        DataSet ds = new DataSet();
        da.Fill(ds);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            table.Rows.Add(ds.Tables[0].Rows[i][0].ToString(),
                Convert.ToDouble(ds.Tables[0].Rows[i][1].ToString()),
                Convert.ToDouble(ds.Tables[0].Rows[i][2].ToString()),
                Convert.ToDouble(ds.Tables[0].Rows[i][3].ToString()),
                Convert.ToDouble(ds.Tables[0].Rows[i][4].ToString()),
            Convert.ToDouble(ds.Tables[0].Rows[i][5].ToString()),
                        Convert.ToDouble(ds.Tables[0].Rows[i][6].ToString()),
                                    Convert.ToDouble(ds.Tables[0].Rows[i][7].ToString()),
                                                Convert.ToDouble(ds.Tables[0].Rows[i][8].ToString()),
                        Convert.ToDouble(ds.Tables[0].Rows[i][9].ToString()),
                    Convert.ToDouble(ds.Tables[0].Rows[i][10].ToString()),
                                        Convert.ToDouble(ds.Tables[0].Rows[i][11].ToString()));
                  
    }
        

        Classifier classifier = new Classifier();
        classifier.TrainClassifier(table);
        string ans = "";
        string uid = Session["id"].ToString();
        try
        {
            SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            string lm = "select top 3 marks from marks_details  where course='SSC' and uid='"+uid+"' order by marks desc";
            da1 = new SqlDataAdapter(lm, con);
            da1.Fill(ds1);
            int sm1 = 0, sm2 = 0, sm3 = 0;
            if (ds1.Tables[0].Rows.Count > 0)
            {

                sm1 = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
                sm2 = Convert.ToInt32(ds1.Tables[0].Rows[1][0].ToString());
                sm3 = Convert.ToInt32(ds1.Tables[0].Rows[2][0].ToString());
            }
            SqlDataAdapter da2;
            DataSet ds2 = new DataSet();
            string m = "select top 3 marks from marks_details  where course='HSC' and uid='" + uid + "' order by marks desc";
            da2 = new SqlDataAdapter(m, con);
            da2.Fill(ds2);
            int hm1 = 0, hm2 = 0, hm3 = 0;
            if (ds2.Tables[0].Rows.Count > 0)
            {

                hm1 = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString());
                hm2 = Convert.ToInt32(ds2.Tables[0].Rows[1][0].ToString());
                hm3 = Convert.ToInt32(ds2.Tables[0].Rows[2][0].ToString());
            }
            ans = classifier.Classify
                (new double[]
                {
                    
                    Convert.ToDouble(score.Text),
                    Convert.ToDouble(score1.Text),
                    Convert.ToDouble(score2.Text),
                    Convert.ToDouble(ssc),
                    Convert.ToDouble(hsc),
                    Convert.ToDouble(sm1),
                     Convert.ToDouble(sm2),
                      Convert.ToDouble(sm3),
                       Convert.ToDouble(hm1),
                        Convert.ToDouble(hm2),
                         Convert.ToDouble(hm3)

                });
        }
        catch (Exception e)
        {

        }
        return ans;
    }
}