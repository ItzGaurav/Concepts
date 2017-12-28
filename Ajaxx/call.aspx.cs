using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class call : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region using  Post Method
        if (Request.Form["a"] != null && Request.Form["b"] != null)
        {
            int a = Convert.ToInt32(Request.Form["a"]);
            int b = Convert.ToInt32(Request.Form["b"]);
            int c = a + b;
            Response.Write("Sum is: " + c);
        }
        #endregion

        #region using  Get Method
        if (Request.QueryString["a"] != null && Request.QueryString["b"] != null)
        {
            int a = Convert.ToInt32(Request.QueryString["a"]);
            int b = Convert.ToInt32(Request.QueryString["b"]);
            int c = a + b;
            Response.Write("Sum is: " + c);
        }
        #endregion
    }
}