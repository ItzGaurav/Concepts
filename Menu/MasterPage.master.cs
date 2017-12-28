using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (TreeNode TNode in TreeView1.Nodes)
        {
            check(TNode);

        }

    }

    protected void check(TreeNode t)
    {
        if (t.NavigateUrl.Equals(Request.AppRelativeCurrentExecutionFilePath))
        {
            t.Selected = true;
        }
        else if (t.ChildNodes.Count > 0)
        {
            foreach (TreeNode cNode in t.ChildNodes)
            {
                check(cNode);
            }
        }

    }
}
