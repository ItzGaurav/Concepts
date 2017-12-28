using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;

public partial class GridView : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=OM-PC\SQLEXPRESS; Initial Catalog=Gaurav; User Id=sa; Password=mv");
    SqlConnection con1 = new SqlConnection(@"Data Source=OM-PC\SQLEXPRESS; Initial Catalog=Gaurav; User Id=sa; Password=mv");
    SqlDataAdapter adap;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            connect();
        }

    }

    //protected void Timer1_Tick(object sender, EventArgs e)
    //{
    //    GridView1.DataBind();
    //    Lmsg.Text = "Last Updated at" + DateTime.Now;
    //}

    //.................GridView Bind....................
    protected void connect()
    {
        adap = new SqlDataAdapter("SELECT * FROM T1", con);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }

    //.................Row_Editing.......................
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        connect();
    }

    //..................Row_CancelingEdit.................
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        connect();
    }

    //...................Row_Updating.........................
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        string id = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label_id")).Text;
        string name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_name")).Text;
        string salary = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_salary")).Text;
        con1.Open();
        cmd = new SqlCommand("UPDATE T1 SET Name='" + name + "',Salary=" + salary + " WHERE ID=" + id + "", con1);
        int t = cmd.ExecuteNonQuery();
        con1.Close();
        GridView1.EditIndex = -1;
        if (t > 0)
        {
            connect();
        }

        else
        {
            Response.Write("Error");
        }
        
    }


    //.....................Row_Deleting........................
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label_id")).Text;
        con.Open();
        cmd = new SqlCommand("DELETE T1 WHERE ID="+id+"",con);
        cmd.ExecuteNonQuery();
        connect();
        con.Close();
    }


    //...................Page.Index.Changing.....................
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        connect();

    }

    
    //....................Row.Data.Bound.............................
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int salary = Convert.ToInt32(((Label)e.Row.FindControl("Label_salary")).Text);
            if (salary <= 4000)
            {
                e.Row.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                e.Row.BackColor = System.Drawing.Color.LightGreen;
            }
        }
    }


    //......................Row.Commend...Insert..........................
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("INSERT"))
        {

            string name = ((TextBox)GridView1.FooterRow.FindControl("ftxt_name")).Text;
            int salary = Convert.ToInt32(((TextBox)GridView1.FooterRow.FindControl("ftxt_salary")).Text);
            con.Open();
            cmd = new SqlCommand("INSERT INTO T1(Name,Salary) values('"+name+"',"+salary+")",con);
            int t = cmd.ExecuteNonQuery();
            if (t > 0)
            {
                connect();
            }
            else
            {
                Response.Write("Error");
            }
        }
    }


    //...................................CheckBox...................................

    protected void cb_header_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox cb_h = (CheckBox)GridView1.HeaderRow.FindControl("cb_header");
        if (cb_h.Checked == true)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("cb_item");
                cb.Checked = true;
            }
        }
        else
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("cb_item");
                cb.Checked = false;
            }
        }
    }

    protected void cb_item_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox cb_h = (CheckBox)GridView1.HeaderRow.FindControl("cb_header");
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox cb = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("cb_item");
            if (cb.Checked == false)
            {
                cb_h.Checked = false;
            }
        }
    }


   //...........................For Create Row...............................
    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            //try
            //{

            //    GridView HeaderGrid = (GridView)sender;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            GridViewRow HeaderGridRow = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
            TableCell Headercell = new TableCell();
            Headercell.Text = "Employee ID";
            Headercell.ColumnSpan = 3;
            HeaderGridRow.Cells.Add(Headercell);

            Headercell = new TableCell();
            Headercell.Text = "Employee details";
            Headercell.ColumnSpan = 2;
            HeaderGridRow.Cells.Add(Headercell);

            Headercell = new TableCell();
            Headercell.Text = "Manupulation";
            Headercell.ColumnSpan = 2;
            HeaderGridRow.Cells.Add(Headercell);


            GridView1.Controls[0].Controls.AddAt(0, HeaderGridRow);
        }
    }
}