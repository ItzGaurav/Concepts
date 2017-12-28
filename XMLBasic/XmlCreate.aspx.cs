using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Text;

public partial class XmlCreate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<xml>");
        for (int i = 0; i < 10; i++)
        {
            sb.Append("<Boy>");
            sb.Append(string.Format("{0}<name>{1}</name>", Environment.NewLine, TextBox1.Text));
            sb.Append(string.Format("{0}<class>{1}</class>", Environment.NewLine, TextBox2.Text));
            sb.Append(string.Format("{0}<marks>{1}</marks>", Environment.NewLine, TextBox3.Text));
            sb.Append("</Boy>");
        }
        sb.Append("</xml>");
        File.WriteAllText(string.Format(Server.MapPath("xml") + "//1.xml"), sb.ToString());

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("XmlRead.aspx");
    }
}