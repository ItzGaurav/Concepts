<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridView.aspx.cs" Inherits="GridView" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GridView Customization By Gaurav</title>
    <style type="text/css">
        .Background
        {
            background-color: Gray;
            filter: alpha(opacity=40);
            opacity: 0.4;
        }
        
        .Pnl
        {
            position: static;
            top: 10%;
            left: 10px;
            width: 300px;
            height: 100px;
            text-align: center;
            background-color: White;
            border: solid 3px black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            <br />
         
          

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Width="60%"
                OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting"
                OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" AllowPaging="true"
                PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound"
                ShowFooter="true" OnRowCommand="GridView1_RowCommand" 
                onrowcreated="GridView1_RowCreated">
                <Columns>
                    <asp:TemplateField HeaderStyle-Width="10%">
                        <HeaderTemplate>
                            <asp:CheckBox ID="cb_header" OnCheckedChanged="cb_header_CheckedChanged" AutoPostBack="true"
                                runat="server" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="cb_item" runat="server" AutoPostBack="true" OnCheckedChanged="cb_item_CheckedChanged" />
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="cb_lb" Text="Delete" CommandName="D_selected" runat="server"></asp:LinkButton>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SN" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ID" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="Label_id" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="Label_name" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_name" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="ftxt_name" BorderColor="Red" BorderWidth="2px" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Salary" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="Label_salary" runat="server" Text='<%#Eval("Salary") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_salary" runat="server" Text='<%#Eval("Salary") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="ftxt_salary" BorderColor="Red" BorderWidth="2px" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lb_Edit" runat="server" CommandName="EDIT" Text="Edit"></asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="lb_Cancel" runat="server" CommandName="CANCEL" Text="Cancel"></asp:LinkButton>
                            <asp:LinkButton ID="lb_Update" runat="server" CommandName="UPDATE" Text="Update"></asp:LinkButton>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lb_Delete" runat="server" CommandName="DELETE" Text="Delete"></asp:LinkButton>

                          <%--  .....................................Conformation Box........................................--%>
                            <cc1:ConfirmButtonExtender ID="CBE1" runat="server" TargetControlID="lb_Delete" DisplayModalPopupID="MPE1">
                            </cc1:ConfirmButtonExtender>
                            <cc1:ModalPopupExtender ID="MPE1" runat="server" TargetControlID="lb_Delete" CancelControlID="cbtn"
                                PopupControlID="Panel1" OkControlID="Okbtn" X="400" Y="100" BackgroundCssClass="Background">
                            </cc1:ModalPopupExtender>
                            <asp:Panel ID="Panel1" runat="server" CssClass="Pnl">
                            <br />
                           Do you want to delete this record
                            <br /><br />
                            <asp:Button ID="cbtn" Text="NO" runat="server" />
                            <asp:Button ID="Okbtn" Text="YES" runat="server" /> 
                            <h5 style="color:Red"> Gaurav</h5>
                            </asp:Panel>

                          <%--  ......................................................................................................--%>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="lb_Insert" runat="server" Text="Insert" CommandName="INSERT"></asp:LinkButton>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
          
            <br />
            <br />
            <asp:Label ID="Lmsg" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
        </center>
    </div>
    </form>
</body>
</html>
