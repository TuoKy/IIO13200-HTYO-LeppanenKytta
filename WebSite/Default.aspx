<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div id="navigationTop">
       <!--lisää on client klik -->
       <asp:Button ID="classCards1" runat="server" Text="Button" />
       <asp:Button ID="classCards2" runat="server" Text="Button" />
       <asp:Button ID="classCards3" runat="server" Text="Button" />
       <asp:Button ID="classCards4" runat="server" Text="Button" />
       <asp:Button ID="classCards5" runat="server" Text="Button" />
       <asp:Button ID="classCards6" runat="server" Text="Button" />
       <asp:Button ID="classCards7" runat="server" Text="Button" />
       <asp:Button ID="neutralCards" runat="server" Text="Button" />
    </div>
    <div id="cards">
        <table>
            <tr>
                <td><asp:Image ID="Image1" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/CS2_087.png" CssClass="imageStyle"/></td>
                <td><asp:Image ID="Image2" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/DS1_233.png" CssClass="imageStyle"/></td>
                <td><asp:Image ID="Image3" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/EX1_246.png" CssClass="imageStyle"/></td>
                <td><asp:Image ID="Image4" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/CS2_150.png" CssClass="imageStyle"/></td>
            </tr>
            <tr>
                <td><asp:Image ID="Image5" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/CS2_087.png" CssClass="imageStyle"/></td>
                <td><asp:Image ID="Image6" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/DS1_233.png" CssClass="imageStyle"/></td>
                <td><asp:Image ID="Image7" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/EX1_246.png" CssClass="imageStyle"/></td>
                <td><asp:Image ID="Image8" runat="server" ImageUrl="http://wow.zamimg.com/images/hearthstone/cards/enus/original/CS2_150.png" CssClass="imageStyle"/></td>
            </tr>
        </table>       
    </div>

    <div id="buttonsSide">
        <asp:Button ID="Create" runat="server" Text="Create new deck" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </div>

</asp:Content>


