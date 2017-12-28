<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Paiging.aspx.cs" Inherits="Paiging" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <center>
            <asp:GridView ID="GV1" runat="server" AllowPaging="True" PageSize="3" OnPageIndexChanging="GV1_PageIndexChanging">
            </asp:GridView>
            <asp:LinkButton ID="lb_back" Text="Back" runat="server" onclick="lb_back_Click"></asp:LinkButton>
        </center>
    </div>
    </form>
</body>
</html>
