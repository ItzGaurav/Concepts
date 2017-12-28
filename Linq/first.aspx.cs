using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class first : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      // Linq_Count(); //and count, MIN,MAX, ORDERBY
        // Linq_All();
         // Linq_Any(); //and contain, Distinct
         Linq_Reverse();  // and skip
      //  Linq_SkipWhile();  // and ElementAt
    }


    protected void Linq_Count()
    {
        string[] colors = { "Red", "SkyBlue", "SeaGreen", "Orange", "Salmon" };
       // List<string> newcolor = (from cc in colors
        //                         where cc.StartsWith("S")
        //                         select cc).ToList();

          //  List<string> newcolor=  colors.Where(c => c.StartsWith("O")).ToList();


        

        IEnumerable<string> newcolor = from cc in colors where cc.StartsWith("S") select cc;

        //IEnumerable<string> newcolor = from cc in colors
        //                               where cc.StartsWith("S")
        //                               orderby cc descending
        //                               select cc;

        foreach (var item in newcolor)
        {
            Response.Write(item + "<br/>");
        }

        int count = newcolor.Count();
        Response.Write(count);


        //MAX(), MIN() basically it for Intiger
        string max = newcolor.Max().ToString();
        string min = newcolor.Min().ToString();
        Response.Write("MAX=" + max + " MIN=" + min);
    }

    protected void Linq_All()
    {
        //It tells you if all the elements in a collection match a certain condition.
        string[] colors = { "Sed", "SkyBlue", "SeaGreen", "Srange", "Salmon" };

        //var startwithA = (from cc in colors
        //                  select cc).All(cc => cc.StartsWith("S"));

        var startwithA = colors.All(c => c.StartsWith("A"));
        Response.Write(startwithA);


    }

    protected void Linq_Any()
    {
        string[] colors = { "Red","Red", "SkyBlue", "SeaGreen", "Orange", "Salmon" };
        //Boolean chk = (from cc in colors
        //               select cc).Any(cc => cc.StartsWith("A"));
        Boolean chk = colors.Any(c => c.StartsWith("A"));

        Boolean chk1 = (from cc in colors
                        select cc).Any(cc => cc.StartsWith("S"));

        Response.Write("IS Any Start with A=" + chk + "<br/>");
        Response.Write("IS Any Start with S=" + chk1 + "<br/>");


        //Boolean contain = (from cc in colors
        //                   select cc).Contains("Red");

        //Boolean contain = (from cc in colors
        //                   select cc).Any(cc => cc.Contains("Red"));
        Boolean contain = colors.Any(c => c.Contains("Re"));

        Response.Write("IS contain Red=" + contain + "<br/>");

        //=====================Distinct==============

        IEnumerable<string> newwww = (from cc in colors
                                      select cc).Distinct();

        List<string> dd = colors.Select(c => c).Distinct().ToList();
        foreach (var item in dd)
        {
            Response.Write(item + "<br/>");
        }

    }



    protected void Linq_Reverse()
    {
        string[] colors = { "Red", "SkyBlue", "SeaGreen", "Orange", "Salmon" };

        // IEnumerable<string> newarr = colors.Reverse();

        IEnumerable<string> newarr = colors.Skip(2); // top 2 skip
        foreach (var item in newarr)
        {

            Response.Write(item + "<br/>");
        }

    }



    protected void Linq_SkipWhile()
    {
     
        int[] intarr = { 1, 2, 3, 4, 5, 7, 11, 12, 13, 22, 33, 44, 32, 34, 16 };
        IEnumerable<int> newarr = intarr.SkipWhile(cc => cc < 10);
        foreach (var item in newarr)
        {

            Response.Write(item + "<br/>");
        }

        int t = intarr.ElementAt(2);
        Response.Write("Element at position 2=" + t);

    }

}