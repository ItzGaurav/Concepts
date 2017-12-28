using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class select : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // select1();
            // select2();
           // select3();
            select4();
        }
    }

    protected void select1()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // one add in every number
        //var numsPlusOne =
        //    from n in numbers
        //    select n + 1;
        var numsPlusOne = numbers.Select(c => c + 1);

        Response.Write("Numbers + 1:");
        foreach (var i in numsPlusOne)
        {
            Response.Write(i);
        }
    }

    //=====================================
    protected void select2()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var productNames =
        //    from p in numbers
        //    select p;
        var productNames = numbers.Select(c => c);

        Response.Write("Product Names:");
        foreach (var productName in productNames)
        {
            Response.Write(productName);
        }
    }
    //========================================

    protected void select3()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] str = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var textNums =
            from n in numbers
            select str[n];

        Response.Write("Number strings:" + "<br/>");
        foreach (var s in textNums)
        {
            Response.Write(s + "<br/>");
        }
    }

    //=========================================\

    public void select4()
    {
        //int[] sal={10, 12, 15 , 7, 8 };

        //var max = sal.Select(c => c).Max();
        //Response.Write(max);

        //var all = sal.Select(c => c);
        //foreach (var item in all)
        //{
        //    Response.Write(item + "<br/>");
            
        //}


      //  string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        //var upperLowerWords =
        //    from w in words
        //    select new { Upper = w.ToUpper(), Lower = w.ToLower() };

   //     var upp = words.Select(c => c.ToUpper());
        //foreach (var ul in upperLowerWords)
        //{
        //    //response.write(ul.upper + "<br/>");
        //    //response.write(ul.lower + "<br/>");
        //}


    //    foreach (var item in upp)
  //      {
     //       Response.Write(item + "<br/>");
            
     //   }
    }
}