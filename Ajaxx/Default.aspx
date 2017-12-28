<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="P1" runat="server" GroupingText="Ajax with Get & Post">
                First Number:
            <input type="text" id="first" />
                <br />
                Second Number:
            <input type="text" id="second" />
                <br />
                <input type="button" id="btn1" value="Get Result" />
                <div id="div1">
                </div>
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="P2" runat="server" GroupingText="JQuery Get & Post Method">
                F Number:
                <input id="f" type="text" />
                <br />
                S Number:
                <input id="s" type="text" />
                <br />
                <input id="btn2" type="button" value="Call Post" />
                <input id="btn3" type="button" value="Call Get" />
                <div id="div2"></div>
            </asp:Panel>

            <br />
            <br />
            <asp:Panel ID="P3" runat="server" GroupingText="Json">
                To Load Json Data from the Server getJSON() method can be used.


            </asp:Panel>

        </div>
    </form>

    <script type="text/javascript" src="JavaScript.js"></script>
    <%-- --------- Ajax Get & Post------------%>
    <script type="text/javascript">
        $("#btn1").click(function () {
            var x = $("#first").val();
            var y = $("#second").val();
            $.ajax({
                type: "Post",  // Get or Post
                url: "call.aspx",
                data: { a: x, b: y }, // "a=5&b=3"
                success: function (msg) {
                    $("#div1").text(msg);
                }

            });
        });
    </script>
    <%-- --------- ------------- -------------%>

    <%-- --------- Ajax Get & Post------------%>
    <script type="text/javascript">

        $("#btn2").click(function () {
            var x1 = $("#f").val();
            var y1 = $("#s").val();
            $.post("call.aspx", { a: x1, b: y1 }, function (data) { $("#div2").text(data) })
        });
        $("#btn3").click(function () {
            var x2 = $("#f").val();
            var y2 = $("#s").val();
            $.get("call.aspx", { a: x2, b: y2 }, function (data) { $("#div2").html("<b> The Result is :" + data + "</b>") })
        });

    </script>
    <%-- --------- ------------- -------------%>
</body>
</html>
