<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 100%; width: 100%">
            <center>
            <div style="height: 40%; width: 90%; background-color:antiquewhite">
                <br />
                
                <asp:Label ID="lbl1" runat="server" Text="Add/Edit Customer" Font-Bold="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <br />
                <br />
                <table style="height: 40%; width: 90%;">
                    <tr>
                        <td style="width:33%;">
                       <b>First Name:</b>    <asp:TextBox ID="txtFN" ValidationGroup="G1" runat="server" MaxLength="100" Width="250px"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rfv1" ErrorMessage="*" ControlToValidate="txtFN" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td style="width:33%;">
                          <b>Middle Name:</b>  <asp:TextBox ID="txtMN" runat="server" MaxLength="100"  Width="250px"></asp:TextBox>


                        </td>
                        <td style="width:33%;">
                           <b>Last Name:</b> <asp:TextBox ID="txtLN" ValidationGroup="G1"  runat="server" MaxLength="100"  Width="250px"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rfv2" ErrorMessage="*" ControlToValidate="txtLN" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        
                        <td colspan="3"><b>Address:</b>
                          <asp:TextBox runat="server" ID="txtADD" ValidationGroup="G1" TextMode="MultiLine"  Width="250px" Style="margin-left:20px"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rfv3" ErrorMessage="*" ControlToValidate="txtADD" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>

                        <td colspan="3">
                            <b>Number:</b>
                           <asp:TextBox ID="txtNUM" runat="server" TextMode="Number" MaxLength="10" ValidationGroup="G1"  Width="250px" Style="margin-left:20px"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rfv4" ErrorMessage="*" ControlToValidate="txtNUM" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>
                            <input type="reset" value="Reset" name="Reset" />
                        
                            <asp:Button ID="btnSubmit" runat="server"  Text="Save" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>

                </table>
            </div>
                <br />
                <br />
                <div style="height: 60%; width: 90%; background-color:ActiveCaption">
            <br />
                    <asp:Label ID="Label1" runat="server" Text="Customers Listing" Font-Bold="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
            <asp:GridView ID="GV1" runat="server" AutoGenerateColumns="false" OnRowCommand="GV1_RowCommand" style="height: 60%; width: 90%">
                <Columns>

                    <asp:TemplateField HeaderText="First Name" ItemStyle-Width="13%">
                        <ItemTemplate>
                            <asp:Label ID="lbl_FN" runat="server" Text='<%#Eval("Firstname") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Middle Name" ItemStyle-Width="13%">
                        <ItemTemplate>
                            <asp:Label ID="lbl_MN" runat="server" Text='<%#Eval("MiddleName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name" ItemStyle-Width="13%">
                        <ItemTemplate>
                            <asp:Label ID="lbl_LN" runat="server" Text='<%#Eval("LastName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address" ItemStyle-Width="35%">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ADD" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Number" ItemStyle-Width="13%">
                        <ItemTemplate>
                            <asp:Label ID="lbl_NUM" runat="server" Text='<%#Eval("Number") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Action" ItemStyle-Width="13%">
                        <ItemTemplate>
                           <asp:LinkButton ID="btn_edit" runat="server" ValidationGroup="G2" CommandName="EDITCUSTOMER" CommandArgument='<%#Eval("Id") %>' Text="Edit"></asp:LinkButton>
                            <asp:LinkButton ID="btn_del" runat="server" ValidationGroup="G2" OnClientClick="return confirm('Are you sure you want to delete this customer?');" CommandName="DELCUSTOMER" CommandArgument='<%#Eval("Id")%>' Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
                    <br />
                </div>
        </center>

        </div>
    </form>
</body>
</html>
