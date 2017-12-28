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
public class studentService : System.Web.Services.WebService
{
    [WebMethod]
    public void GetAllStudentList()
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=foo;User Id=sa;Password=cms");
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Id,Name,Gender,City from tblStudent", con);
        SqlDataReader rd = cmd.ExecuteReader();
        List<StudentInfo> studentInfoList = new List<StudentInfo>();
        while (rd.Read())
        {
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.Id = Convert.ToInt32(rd["Id"]);
            studentInfo.Name = rd["Name"].ToString();
            studentInfo.Gender = rd["Gender"].ToString();
            studentInfo.Gender = rd["City"].ToString();
            studentInfoList.Add(studentInfo);
        }
        con.Close();
        JavaScriptSerializer js = new JavaScriptSerializer();
        Context.Response.Write(js.Serialize(studentInfoList));
    }

}
