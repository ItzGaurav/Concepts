using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public partial class RowSelection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gridView.DataSource = GetDataSource();
            gridView.DataBind();
        }
    }
    private DataTable GetDataSource()
    {
        DataTable dTable = new DataTable();
        DataRow dRow = null;
        Random rnd = new Random();

        dTable.Columns.Add("sno");
        dTable.Columns.Add("rndno");
        dTable.Columns.Add("date");
        dTable.Columns.Add("time");

        for (int n = 0; n < 10; ++n)
        {
            dRow = dTable.NewRow();

            dRow["sno"] = n + ".";
            dRow["rndno"] = rnd.Next().ToString();
            dRow["date"] = DateTime.Now.ToShortDateString();
            dRow["time"] = DateTime.Now.ToShortTimeString();

            dTable.Rows.Add(dRow);
            dTable.AcceptChanges();
        }

        return dTable;
    }
    protected void gridView_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
        {
            e.Row.TabIndex = -1;
            e.Row.Attributes["onclick"] = string.Format("javascript:SelectRow(this, {0});", e.Row.RowIndex);
            e.Row.Attributes["onkeydown"] = "javascript:return SelectSibling(event);";
            e.Row.Attributes["onselectstart"] = "javascript:return false;";
        }
    }
}