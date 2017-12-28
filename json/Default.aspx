<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <script type="text/javascript">
       var test = [
       {"name":"Gaurav", "age":23,"Designation":"technocrat"},
       {"name":"AAAA", "age":22, "Designation":"SD"},
       {"name":"BBB", "age":28, "Designation":"SEO"},
       {"name":"CCCC", "age":26, "Designation":"Support"}
       ];
//       for (var i = 0; i <= test.length; i++) {
//           document.write(test[i].name);
//           document.write("<br/>");
       //    }
       
       var a = test[0].name;
       document.write(a);
       
   
   </script>
   
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
