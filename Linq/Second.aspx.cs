using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Second : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //  Linq_First();  //same for Linq_Last()
        //  Linq_FirstOrDefault(); //same for Linq_LastOrDefault()
        // Linq_Take(); //Linq TakeWhile
        Linq_Concat(); // Error
    }

    protected void Linq_First()
    {
        string[] colors = { "Red", "SkyBlue", "SeaGreen", "Orange", "Salmon" };
        // string firstt = colors.First(); //simple
        //string firstt = (from cc in colors
        //                 select cc).First();

        //string firstt = (from cc in colors  
        //                 select cc).First(cc => cc.StartsWith("S"));

        string firstt = colors.First(c => c.StartsWith("S"));
        Response.Write("first element stat with S is=" + firstt);
    }


    protected void Linq_FirstOrDefault()
    {
        string[] emptyArr = { };
        string[] colors = { "Red", "SkyBlue", "SeaGreen", "Orange", "Salmon" };

        string C = (from cc in colors
                    select cc).FirstOrDefault();
        Response.Write("first OR Default element is=" + C + "<br/>");

        string x = (from cc in emptyArr
                    select cc).FirstOrDefault();
        Response.Write("first OR Default element(of empty array) is=" + x + "<br/>");


        string y = (from cc in colors
                    select cc).FirstOrDefault(cc => cc.StartsWith("O"));
        Response.Write("first OR Default element with condition is=" + y + "<br/>");

    }

    protected void Linq_Take()
    {
        int[] intarr = { 1, 24, 41, 5, 7, 13, 22, 33, 44, 32, 34, 16 };

        //  IEnumerable<int> val = intarr.OrderByDescending(n => n).Take(3);
        IEnumerable<int> val = intarr.OrderByDescending(n => n).TakeWhile(cc => cc > 10);

        foreach (var item in val)
        {
            Response.Write(item + "<br/>");
        }
    }

    protected void Linq_Concat()
    {
        string[] fruitsStartsWithA = { "Actinidia deliciosa", "Albero del pane", "Annona muricata" };
        string[] fruitsStartsWithB = { "Brazilian pawpaw", "Bramble fruit" };
       // var allfruits = fruitsStartsWithA.Concat(fruitsStartsWithB);
        IEnumerable<string> allfruits = fruitsStartsWithA.Concat(fruitsStartsWithB);
        foreach (string item in allfruits)
        {
            Response.Write(allfruits);
        }


        int[] ints1 = { 1, 2, 3 };
        int[] ints2 = { 3, 4, 5 };
        IEnumerable<int> union = ints1.Union(ints2);
        Response.Write("Union" + "<br/>");
        foreach (int num in union)
        {
            Response.Write(num + "<br/>");
        }
       
        IEnumerable<int> concat = ints1.Concat(ints2);
        Response.Write("Concat" + "<br/>");
        foreach (int num in concat)
        {
            Response.Write(num +"<br/>");
        }


    }
}