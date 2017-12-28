using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request_Response : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        Response.Write("<b><i>Request Type=</i></b>" + Request.RequestType + "</br></br>");

        Response.Write("<b><i>BrowserName=</b></i>" + Request.Browser.Type + "</br></br>");

        Response.Write("<b><i>IsJavaScript Support=</i></b>" + Request.Browser.JavaScript + "</br></br>");

        Response.Write("<b><i>IsCookies Support=</i></b>" + Request.Browser.Cookies + "</br></br>");

        Response.Write("<b><i>Language=</i></b>" + Request.UserLanguages[0] + "</br></br>");

        Response.Write("<b><i>Ip Address=</i></b>" + Request.UserHostName + "</br></br>");

        Response.Write("<b><i>Url=</i></b>" + Request.Url + "</br/></br>");

        Response.Write("<b><i>User Agent=</i></b>" + Request.UserAgent + "</br/></br>");

        Response.Write("<b><i>User Host Name=</i></b>" + Request.UserHostName + "</br></br>");

        Response.Write("<b><i>Physical Path=</i></b>" + Request.PhysicalPath + "</br></br>");

        Response.Write("<b><i>Physical Application Path=</i></b>" + Request.PhysicalApplicationPath + "</br></br>");

        Response.Write("<b><i>Path=</i></b>" + Request.Path + "</br></br>");

        Response.Write("<b><i>Application Path=</i></b>" + Request.ApplicationPath + "</br></br>");
    }
}