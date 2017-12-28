using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            connect();
        }
    }


    protected void connect()
    {

        DataTable dt = new DataTable();
        dt.Columns.Add("id");
        dt.Columns.Add("Time");
        dt.Columns.Add("desc");


        if (File.Exists(string.Format(Server.MapPath("xml") + "\\notice1.xml")))
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("xml") + "\\notice1.xml");

            XmlNodeList xh1 = xdoc.GetElementsByTagName("heading");
            XmlNodeList xh2 = xdoc.GetElementsByTagName("subheading");

            XmlNodeList xt = xdoc.GetElementsByTagName("time");
            XmlNodeList xd = xdoc.GetElementsByTagName("value");


            txth1.Text = xh1[0].InnerText;
            txth2.Text = xh2[0].InnerText;

            for (int i = 0; i < xt.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;
                dr[1] = xt[i].InnerText;
                dr[2] = xd[i].InnerText;
                dt.Rows.Add(dr);

            }
            Gv1.DataSource = dt;
            Gv1.DataBind();
        }
        else
        {
            txth1.Text = " ";
            txth2.Text = " ";
            for (int i = 0; i < 5; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "";
                dr[1] = "";
                dr[2] = "";
                dt.Rows.Add(dr);
            }

            Gv1.DataSource = dt;
            Gv1.DataBind();


        }


    }

    protected void btn_addmore_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("id");
        dt.Columns.Add("Time");
        dt.Columns.Add("desc");
        for (int i = 0; i < Gv1.Rows.Count; i++)
        {
            TextBox Time = (TextBox)(Gv1.Rows[i].Cells[0].FindControl("txttime"));
            TextBox desc = (TextBox)(Gv1.Rows[i].Cells[1].FindControl("txtdesc"));
            DataRow dr = dt.NewRow();
            dr[1] = Time.Text;
            dr[2] = desc.Text;
            dt.Rows.Add(dr);

        }
        for (int j = 1; j < 5; j++)
        {
            DataRow dr = dt.NewRow();
            dr[1] = "";
            dr[2] = "";
            dt.Rows.Add(dr);
        }

        Gv1.DataSource = dt;
        Gv1.DataBind();
    }
    protected void btn_generate_Click(object sender, EventArgs e)
    {
        generate_xml();
        connect();

    }

    protected void generate_xml()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(String.Format("{0}<Question>{0}", Environment.NewLine));
        sb.Append(string.Format("{0}<rss id=\"classroom\" questionfont=\"font face='arial' size=5 color=000000\"   color=\"000000\" size=\"6\" rssinterval=\"15000\" checkagain=\"10000\"  bgcolor=\"FFFFFF\" defaultmsg=\"\" url=\"xml/Question.xml\" namefont=\"font face='arial' size=6 color=66CC00\" questionsperpage=\"3\" defaultfrom=\"No question are available\" seperator=\"\" currentstate=\"notice\" />{0}", Environment.NewLine));
        sb.Append(string.Format("{0}<notice>{0}", Environment.NewLine));
        sb.Append(string.Format("{0}<heading>{1}</heading>{0}", Environment.NewLine, txth1.Text));
        sb.Append(string.Format("{0}<subheading>{1}</subheading>{0}", Environment.NewLine, txth2.Text));


        for (int i = 0; i < Gv1.Rows.Count; i++)
        {
            sb.Append(string.Format("{0}<text>{0}", Environment.NewLine));
            TextBox txt1 = (TextBox)(Gv1.Rows[i].FindControl("txttime"));
            TextBox txt2 = (TextBox)(Gv1.Rows[i].FindControl("txtdesc"));
            sb.Append(string.Format("{0}<time>{1}</time>{0}", Environment.NewLine, txt1.Text));
            sb.Append(string.Format("{0}<value>{1}</value>{0}", Environment.NewLine, txt2.Text.Replace("&", "&amp;")));
            sb.Append(string.Format("{0}</text>{0}", Environment.NewLine));
        }
        sb.Append(string.Format("{0}</notice>{0}", Environment.NewLine));
        sb.Append(String.Format("{0}</Question>{0}", Environment.NewLine));

        File.WriteAllText(string.Format(Server.MapPath("xml") + "//notice1.xml"), sb.ToString());
    }

}
