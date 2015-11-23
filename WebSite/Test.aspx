<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="..."></asp:Label>
    </div>
        <asp:GridView ID="Grid" runat="server" Height="254px" Width="512px">
        </asp:GridView>
    </form>
</body>
</html>
