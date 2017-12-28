using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class NastedGV : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MvCon"].ConnectionString);
    SqlCommand cmd;
    SqlDataAdapter adap;
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }

    protected void bind()
    {
        adap = new SqlDataAdapter("Select * from stud", con);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        GV1.DataSource = ds;
        GV1.DataBind();

    }
    protected void GV1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string sid = ((Label)e.Row.FindControl("lbl_class")).Text;
            adap = new SqlDataAdapter("Select Sub_name from subject where class='" + sid + "'", con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            ((GridView)e.Row.FindControl("GV2")).DataSource = ds;
            ((GridView)e.Row.FindControl("GV2")).DataBind();
            

        }
    }
}