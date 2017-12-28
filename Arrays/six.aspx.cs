using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class six : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // array_except(); //Except subtracts elements from a collection.   // MIN and MAX
        array_filter(); // and remove element
    }

    protected void array_except() // Remove all arr2 from arr1.
    {
        int[] arr1 = { 1, 3, 5, 7, 8, 9 };
        int[] arr2 = { 1, 8, 9 };
        var result = arr1.Except(arr2);
        foreach (var item in result)
        {
            Response.Write(item + "<br/>");
        }
        Response.Write("---------MIN and MAX Value------" + "<br/>");
        int minvalue = arr1.Min();
        int maxvalue = arr1.Max();
        Response.Write("MIN VALUE=" + minvalue + " MAX VALUE=" + maxvalue);

    }

    protected void array_filter()
    {
        string[] birds = { "Rock Parrot", "Crimson Rosella", "Regent Parrot", "Superb Parrot", "Red Lory", "African Emerald Cuckoo" };

        //this line filter birds array and populate a new array.
        string[] filteredbirds = Array.FindAll(birds, x => x.EndsWith("Parrot"));
        foreach (var item in filteredbirds)
        {
            Response.Write(item + "<br/>");
        }

        //for remove element
        List<string> birdslist = birds.ToList();
        //remove (delete) elements at index 0. first element
        birdslist.RemoveAt(0);
        Array.Resize(ref birds, birds.Length - 1);
        for (int i = 0; i < birds.Length; i++)
        {
            birds[i] = birdslist[i];
        }
        Response.Write("---------After Remove element------" + "<br/>");
        foreach (var item in birdslist)
        {
            Response.Write(item + "<br/>");
        }
    }
}