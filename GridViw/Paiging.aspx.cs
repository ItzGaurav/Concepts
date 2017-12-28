using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class Paiging : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MvCon"].ConnectionString);
    SqlDataAdapter adap;
    static int temp = 0;
    static int str = 0;
    static int str1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
            temp = GV1.EditIndex;
        }
    }
    protected void bind()
    {
        adap = new SqlDataAdapter("Select * from T1", con);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        GV1.DataSource = ds;
        GV1.DataBind();

    }

    protected void GV1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        temp = str;
        str1 = temp;
        str = e.NewPageIndex;

        GV1.PageIndex = e.NewPageIndex;
        bind();
    }

    protected void lb_back_Click(object sender, EventArgs e)
    {
        if (temp == 0)
        {
            str1 = str;
            str = temp;
            //  temp =-1;
            temp = str1;
            GV1.PageIndex = str;
            bind();

        }
        else if (temp > -1)
        {
            GV1.PageIndex = temp;
            str1 = str;
            str = temp;
            temp = str1;
            bind();
        }

    }
}