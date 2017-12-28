using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Text;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
  
    }

    // Read XML and Bind to Gridview using GridView Properties
    protected void BT1_Click(object sender, EventArgs e)  // Bind XML
    {
        string path = Server.MapPath("XML") + "\\EMP.xml";
        DataSet ds = new DataSet();
        ds.ReadXml(path);
        GV1.DataSource = ds.Tables[1];
        GV1.DataBind();
    }



    // Read XML and Bind to Gridview using XML Properties
    protected void BT2_Click(object sender, EventArgs e)
    {

        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(Server.MapPath("XML") + "//EMP.xml");

        XmlNodeList iid = xdoc.GetElementsByTagName("EID");

       // XmlNodeList xid = xdoc.SelectNodes("/xml/Employees/Employee/EID");
        XmlNodeList xname = xdoc.SelectNodes("/xml/Employees/Employee/Name");
        XmlNodeList xsalary = xdoc.SelectNodes("/xml/Employees/Employee/Salary");
        XmlNodeList xDesignation = xdoc.SelectNodes("/xml/Employees/Employee/Designation");
        DataTable dt = new DataTable();
        dt.Columns.Add("ID");
        dt.Columns.Add("NAME");
        dt.Columns.Add("SALARY");
        dt.Columns.Add("Designation");
        for (int i = 0; i < iid.Count; i++)
        {
            String iddd = iid[i].InnerText;
            String nameee = xname[i].InnerText;
            String salaryeee = xsalary[i].InnerText;
            String designationnn = xDesignation[i].InnerText;
            DataRow dr = dt.NewRow();
            dr["ID"] = iddd;
            dr["NAME"] = nameee;
            dr["SALARY"] = salaryeee;
            dr["Designation"] = designationnn;
            dt.Rows.Add(dr);
        }
        GV2.DataSource = dt;
        GV2.DataBind();

    }


    // Create New XML from older XML
   
    protected void BT3_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(Server.MapPath("XML")+"//EMP.xml");
        XmlNodeList xname = xdoc.SelectNodes("/xml/Employees/Employee/Name");
        XmlNodeList xsalary = xdoc.SelectNodes("/xml/Employees/Employee/Salary");
        sb.Append("<xml>");
        foreach (XmlNode root in xname)
        {
            String str = root.InnerText;
            sb.Append(String.Format("{1}<Name Of Employee>{0}</Name Of Employee>",str,Environment.NewLine));
            sb.Append(String.Format("{1}<Salary>{0}</Salary>", str, Environment.NewLine));
        }
      
        sb.Append("</xml>");
        File.WriteAllText(string.Format(Server.MapPath("XML") + "//New.xml"), sb.ToString());
       
    }



   

    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(Server.MapPath("XML")+"//Text1.xml");
        XmlNodeList xname = xdoc.SelectNodes("/xml/students/student/name");
        foreach (XmlNode node in xname)
        {
             node.RemoveAll();
            xdoc.Save("Text1.xml");
            //xdoc.SelectNodes(node);
            //xdoc.SelectSingleNode(node).RemoveAll();
        }
        //xdoc.Save("Text1.xml");
    }
}