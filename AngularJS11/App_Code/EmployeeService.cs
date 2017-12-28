using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
/// <summary>
/// Summary description for EmployeeService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class EmployeeService : System.Web.Services.WebService
{
    [WebMethod]
    public void GetAllEmployeeList()
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=foo;User Id=sa;Password=cms");
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Id,Name,Gender,Salary from Employee", con);
        SqlDataReader rd = cmd.ExecuteReader();
        List<EmployeeInfo> employeeInfoList = new List<EmployeeInfo>();
        while (rd.Read())
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.Id = Convert.ToInt32(rd["Id"]);
            employeeInfo.Name = rd["Name"].ToString();
            employeeInfo.Gender = rd["Gender"].ToString();
            employeeInfo.Salary = Convert.ToInt32(rd["Salary"]);
            employeeInfoList.Add(employeeInfo);
        }
        con.Close();
        JavaScriptSerializer js = new JavaScriptSerializer();
        Context.Response.Write(js.Serialize(employeeInfoList));
    }

}
