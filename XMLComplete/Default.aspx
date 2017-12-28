<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <table style="width: 90%">
                <tr>
                    <td align="center">
                        Notice Heading:
                        <asp:TextBox ID="txth1" Width="400px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        Table Heading:
                        <asp:TextBox ID="txth2" Width="400px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Gv1" runat="server" Width="100%" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="S.No" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="center">
                                    <ItemTemplate>
                                        <asp:Label ID="txtid" Width="50px" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Time" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="center">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txttime" Width="100px" runat="server" Text='<%#Eval("Time")%>'></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Description" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="center">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtdesc" Width="600px" Style="resize: none;" runat="server" Text='<%#Eval("desc")%>'
                                            TextMode="MultiLine"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btn_addmore" runat="server" Text="Add More" 
                            onclick="btn_addmore_Click" />
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Button ID="btn_generate" runat="server" Text="Generate" 
                            onclick="btn_generate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
