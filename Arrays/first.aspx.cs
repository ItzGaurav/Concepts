using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

public partial class first : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  merge_without_duplicate();
        //  merge_two_arrays();
        //char_array();
        //  Addnew_item_in_existing_array();
        // int_array_average(); //Any Method used in this (check it)
        aaaaa();
    }


    protected void merge_without_duplicate()
    {
        string[] color1 = { "Red", "Green", "Blue" };
        string[] color2 = { "White", "Black", "Red" };

        var allColor = color1.Union(color2);
        // string[] allColor = color1.Union(color2).ToArray(); wrong(but why)?????
        Response.Write(".............array merge without duplicates..............." + "<br/>");
        foreach (var item in allColor)
        {
            Response.Write(item + "<br/>");
        }
        Response.Write(".........................................................");
    }
    protected void merge_two_arrays()
    {
        string[] color1 = { "Red", "Green", "Blue" };
        string[] color2 = { "White", "Black", "Red" };
        List<string> List = new List<string>();

        List.AddRange(color1);
        List.AddRange(color2);
        Response.Write(".............array two merge..............." + "<br/>");
        foreach (var item in List)
        {
            Response.Write(item + "<br/>");

        }

    }


    protected void char_array()
    {
        char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f' };
        foreach (var item in arr)
        {
            Response.Write(item + "<br/>");
        }
        string g = new string(arr);
        Response.Write("string is=" + g); //string of char
    }


    protected void Addnew_item_in_existing_array()
    {
       
        string[] arr = { "Red", "Green", "Pink", "Blue" };
        
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = "BLACK";
        foreach (var item in arr)
        {
            Response.Write(item + "<br/>");
        }
        bool b = arr.Any(i => i.StartsWith("R"));
        Response.Write("Any color start with R=" + b);

    }


    protected void int_array_average()
    {
        int[] marks = { 55, 33, 50, 41, 20 };
        double avg = marks.Average();
        Response.Write("Avrage Marks is=" + avg + "<br/>");
        int sum = 0;
        //foreach (var item in marks)
        //{
        //    sum += item;
        //}
        //......oR
        sum = marks.Sum();
        Response.Write("Sum of Marks is=" + sum + "<br/>");
        //Any Method of C#...Any receives a Predicate. It determines if any element in a collection matches a certain condition.
        bool b1 = marks.Any(item => item % 2 == 0); //See if any elements are divisible by two.
        bool b2 = marks.Any(item => item == 2);
        Response.Write(b1 + "<br/>");
        Response.Write(b2 + "<br/>");
    }

    protected void aaaaa()
    {
        ArrayList ar = new ArrayList();
        ar.Add("GA");
        ar.Add(1);
        foreach (var item in ar)
        {
            Response.Write(item + "<br/>");
        }
    }
}