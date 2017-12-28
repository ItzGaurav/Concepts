using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class third : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Linq_DefaultIfEmpty();  //***
        //Linq_Range();
        // Linq_Repeat();
        Linq_SequenceEqual(); //and Single
    }

    protected void Linq_DefaultIfEmpty()
    {
        string[] colors = { "Red", "SkyBlue", "SeaGreen", "Orange", "Salmon" };

        var startwithA = from cc in colors
                         where cc.StartsWith("A")
                         select cc;
        foreach (var item in startwithA.DefaultIfEmpty("Not Found"))
        {
            Response.Write(item + "<br/>");
        }
    }




    protected void Linq_Range()
    {
        var num = Enumerable.Range(10, 50); //(int start, int count)
        foreach (var item in num)
        {
            Response.Write(item + "<br/>");
        }
    }

    protected void Linq_Repeat()
    {
        var text = Enumerable.Repeat("Gaurav", 5);
        foreach (var item in text)
        {
            Response.Write(item + "<br/>");

        }
    }


    protected void Linq_SequenceEqual()
    {

        string[] fruitsList1 = { "Citrus sinensis", "Diospyros blancoi", "Coconut palm" };
        string[] fruitsList2 = { "Jambosa jambos", "Korean mango", "Malabar plum" };
        string[] fruitsList3 = { "Citrus sinensis", "Diospyros blancoi", "Coconut palm" };

        Response.Write("After Calling SequenceEqual Operator [fruitsList1.Equals(fruitsList2)]: " + fruitsList1.SequenceEqual(fruitsList2) + "<br/>");
        Response.Write("After Calling SequenceEqual Operator [fruitsList1.Equals(fruitsList3)]:" + fruitsList1.SequenceEqual(fruitsList3) + "<br/>");

        var itemEndsWithplum = from cc in fruitsList1
                               where cc.EndsWith("palm")
                               select cc;
        Response.Write("After Calling Single Operator:" + itemEndsWithplum.Single() + "<br/>");
        Response.Write("After Calling SingleOrDefault Operator:" + itemEndsWithplum.SingleOrDefault() + "<br/>");
    }

}