using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Xml;


public partial class XmlRead : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("xml") + "//1.xml";
        // XmlDocument xdoc = new XmlDocument();
        // xdoc.Load(Server.MapPath("XML")+"\\1.xml");
        DataSet ds = new DataSet();
        ds.ReadXml(path);
        gv1.DataSource = ds.Tables[0];
        gv1.DataBind();


    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        Response.Redirect("XmlCreate.aspx");
    }
}