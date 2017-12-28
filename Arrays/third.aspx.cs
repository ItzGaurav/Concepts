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
        //  convert_string_array_to_list();
        // convert_string_to_byte_array(); //and bye array to string
        array_sort_alphabetically(); //Array.sort(arr);
    }

    protected void convert_string_array_to_list()
    {
        string[] arr = { "Red", "Blue", "Black", "White", "Green" };
        List<string> arrlist = arr.OfType<string>().ToList();
        foreach (var item in arrlist)
        {
            Response.Write(item + "<br/>");
        }
    }


    protected void convert_string_to_byte_array()
    {
        string a = "I have  a pen";
        byte[] bytearray = System.Text.Encoding.ASCII.GetBytes(a);
        foreach (var item in bytearray)
        {
            Response.Write(item + "<br/>");
        }

        string txt = System.Text.ASCIIEncoding.ASCII.GetString(bytearray);
        Response.Write(txt);
    }

    protected void array_sort_alphabetically()
    {
        string[] arr = { "Red", "Blue", "Black", "White", "Green" };
        //  Array.Sort(arr); //for Assending
        var result = from element in arr
                     orderby element descending
                     select element;

        foreach (var item in result)
        {
            Response.Write(item + "<br/>");
        }


        string[] newarr = new string[arr.Length]; 
        arr.CopyTo(newarr, 0); //to copy array to another array

    }
}