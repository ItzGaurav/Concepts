using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class second : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void check_missing_number_by_List()
    {
        //List<int> num = new List<int>()
        //{
        //    7,6,1,2,3,5,9,10
        //};
        int[] arr = { 1, 2, 3, 4, 6, 4, 8, 9 };
        for (int i = 0; i < arr.Length - 1; i++)
        {

            if (arr.Contains(i))
            {
            }
            else
            {
                Response.Write("Your missing number is=" + i + "<br/>");
            }
        }
    }


    protected void check_missing_number_by_ownCode()
    {
        int[] arr = { 2, 5, 10, 1, 9, 4 };
        for (int i = 1; i <= 10; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == arr[j])
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                Response.Write("Missing Number is" + i + "<br/>");
            }
        }
    }
}
