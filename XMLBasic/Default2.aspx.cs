using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using System.Text;
using System.IO;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void BT1_Click(object sender, EventArgs e)
    {
        XmlDocument xdoc = new XmlDocument();
        XmlNode xmlNode = xdoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
        XmlElement rootElement = xdoc.CreateElement("HEDDERS");
        xdoc.AppendChild(rootElement);
        for (int i = 10; i < 20; i++)
        {
            // Create <InstallationId> Node
            XmlElement installationElement = xdoc.CreateElement("ID");
            XmlText installationIdText = xdoc.CreateTextNode(Convert.ToString(i));
            installationElement.AppendChild(installationIdText);
            xdoc.ChildNodes.Item(0).AppendChild(installationElement);

            // Create <Environment> Node
            XmlElement environmentElement = xdoc.CreateElement("NAME");
            XmlText environText = xdoc.CreateTextNode("ABC" + i);
            environmentElement.AppendChild(environText);
            xdoc.ChildNodes.Item(0).AppendChild(environmentElement);
        }

 

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<xml>");
        sb.Append("<ID>222</ID>");
        sb.Append("<Name>2222</Name>");
        sb.Append("<IDDDD>2222</IDDDD>");
        sb.Append("<IIII>2222</IIII>");
        sb.Append("</xml>");
        File.WriteAllText(string.Format(Server.MapPath("XML") + "//FIRST.xml"), sb.ToString());
       
    }
}