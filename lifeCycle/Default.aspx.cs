using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
 
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='red'> 1. </font></b></i>   Page PreInit <br/>");
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='red'> 2. </font></b></i> Page Init <br/>");
    }
    protected void Page_InitComplete(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='red'> 3. </font></b></i> Page PreInit Complete </br>");
    }

    protected void Page_PreLoad(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Green'> 4. </font></b></i>  Page PreLoad </br>");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Green'> 5. </font></b></i>Page Load <br/>");
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Green'> 6. </font></b></i> Page Load Complete </br>");
    }

    protected void Page_Prerender(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Blue'> 7. </font></b></i> Page PreRender</br>");
    }
    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Blue'> 8. </font></b></i> Page PreRender Complete</br>");
    }
    protected void Page_SaveStateComplete(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Blue'> 9. </font></b></i> Page SaveState Complete</br>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Grey'> 10. </font></b></i> Button Click </br>");
    }

    protected void Page_UnLoading(object sender, EventArgs e)
    {
        Response.Write("<i><b><font color='Pink'> 11. </font></b></i> Page Unloading Event </br>");
    }
    protected void Page_Render(object sender, EventArgs e)
    {
        Response.Write("<b>Gaurav</br>");
    }
    protected void G1_Click(object sender, EventArgs e)
    {
        Response.Write("Button G1 Click</br>");
    }
}