using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerBLL;
using System.Data;
using Model;

public partial class Customers : System.Web.UI.Page
{
    int Id = 0;
    CustomerBLL.Customers bll = new CustomerBLL.Customers();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetCustomers();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CustomerInfo info = new CustomerInfo();
        info.Id = Convert.ToInt32(Session["Id"]);
        info.FirstName = txtFN.Text;
        info.MiddleName = txtMN.Text;
        info.LastName = txtLN.Text;
        info.Address = txtADD.Text;
        info.Number = txtNUM.Text;

        bool isValid = bll.formValidate(info);  // Validation On Bussion Layer
        if (isValid)
        {

            int t = bll.SaveCustomer(info);
            GetCustomers();
            if (t > 0)
            {
                txtFN.Text = "";
                txtMN.Text = "";
                txtLN.Text = "";
                txtADD.Text = "";
                txtNUM.Text = "";
                ScriptManager.RegisterStartupScript(this, GetType(), "key1", "alert('Customer Save Successfully');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "key1", "alert('Some Error Occure');", true);
            }
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "key1", "alert('Please Fill Manadatry Fields');", true);
        }
    }

    protected void GetCustomers()
    {
        DataSet ds = new DataSet();
        ds = bll.GetCustomers();
        GV1.DataSource = ds;
        GV1.DataBind();
    }

    protected void GV1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EDITCUSTOMER")
        {
            Id = Convert.ToInt32(e.CommandArgument);
            Session["Id"] = Id;
            CustomerInfo info = new CustomerInfo();
            info = bll.GetCustomers(Id);
            txtFN.Text = info.FirstName;
            txtMN.Text = info.MiddleName;
            txtLN.Text = info.LastName;
            txtADD.Text = info.Address;
            txtNUM.Text = info.Number;
        }
        if (e.CommandName == "DELCUSTOMER")
        {
            Id = Convert.ToInt32(e.CommandArgument);
            int t = bll.DeleteCustomer(Id);
            GetCustomers();
            if (t > 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "key2", "alert('Customer Successfully Deleted');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "key2", "alert('Some Error Occure');", true);
            }
        }
    }
}