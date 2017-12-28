using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class fourth : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //  convert_string_array_to_int_array();
        //  string_array_to_csv(); //Comma-separated_values
        //  array_binary_search();
        //  array_clone();
        array_distinct(); // and delete dublicate Record
        //  array_of_objects(); //and Clear Array

    }

    protected void convert_string_array_to_int_array()
    {
        string[] stringarray = { "5", "11", "15", "20", "25" };
        int[] intarray = new int[stringarray.Length]; //fix length of new array
        // int[] intarray = new int[4];

        for (int i = 0; i < stringarray.Length; i++)
        {
            intarray[i] = Convert.ToInt32(stringarray[i]);
        }
        foreach (var item in intarray)
        {
            Response.Write(item + "<br/>");
        }

        string convertedstring = String.Join(", ", intarray); //int array to string array
        Response.Write("Converted int to String is=" + convertedstring);
    }


    protected void string_array_to_csv()
    {
        string[] arr = { "Red", "Blue", "Black", "White", "Green" };
        string commaseparatedstring = String.Join(",", arr);
        string filename = Server.MapPath("csv.txt");
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.Write(commaseparatedstring);
        }
    }



    protected void array_binary_search()
    {
        string[] arr = { "Red", "Blue", "Black", "White", "Green", "Pink", "Yellow" };
        Array.Sort(arr); //binary search work correctly only on a pre sorted array.
        int index = Array.BinarySearch(arr, "Pink");
        Response.Write(index);

    }


    protected void array_clone()
    {
        string[] arr = { "Red", "Blue", "Black", "White", "Green" };
        string[] clonOfarr = arr.Clone() as string[];

        foreach (var item in clonOfarr)
        {
            Response.Write(item);
        }


        arr[3] = "ABCGEFG";
        clonOfarr[1] = "Gaurav";

        Response.Write("<br/>" + "...........simple array.........." + "<br/>");
        foreach (var item in arr)
        {
            Response.Write(item + "<br/>");
        }
        Response.Write("...........clone of array.........." + "<br/>");
        foreach (var item in clonOfarr)
        {
            Response.Write(item + "<br/>");
        }
    }


    protected void array_distinct()
    {
        string[] arr = { "Red", "Blue", "Black", "White", "Green", "Black", "White" };

        string[] distinctArr = arr.Distinct().ToArray();

        foreach (var item in distinctArr)
        {
            Response.Write(item + "<br/>");
        }
        //delete dublicate Record


        Array.Resize(ref arr, distinctArr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = distinctArr[i];
        }

        Response.Write(".......After Deleting Duplicate value......" + "<br/>");
        foreach (var item in arr)
        {
            Response.Write(item + "<br/>");
        }
    }



    protected void array_of_objects()
    {
        object[] objectarr = { "one", "1", null, "A", true, 2.25 };
        foreach (var item in objectarr)
        {
            Response.Write(item + "<br/>");
        }
        Array.Clear(objectarr, 0, objectarr.Length);
        Response.Write("---------------Clear Array---------------");
        foreach (var item in objectarr)
        {
            Response.Write(item + "<br/>");
        }
    }




}