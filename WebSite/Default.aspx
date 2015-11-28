<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function showCall() {
            aler("plaa");
        }
    </script>
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
         
        <asp:ImageButton ID="previous" runat="server" ImageUrl="Images/arrowBack.png" CssClass="arrowStyleLeft" OnClick="previous_Click" />

        <asp:Image ID="Image1" runat="server" CssClass="imageStyle"/>
        <asp:Image ID="Image2" runat="server" CssClass="imageStyle"/>
        <asp:Image ID="Image3" runat="server" CssClass="imageStyle"/>
        <asp:Image ID="Image4" runat="server" CssClass="imageStyle"/>
                 
        <asp:Image ID="Image5" runat="server" CssClass="imageStyle"/>
        <asp:Image ID="Image6" runat="server" CssClass="imageStyle"/>
        <asp:Image ID="Image7" runat="server" CssClass="imageStyle"/>
        <asp:Image ID="Image8" runat="server" CssClass="imageStyle"/>     
        
        <asp:ImageButton type="button" ID="next" runat="server" clientidmode="Static" ImageUrl="Images/arrowNext.png" CssClass="arrowStyleRight" onClick="next_Click" />    

    </div>
    
    <div id="buttonsSide">
        <asp:Button ID="Create" runat="server" Text="Create new deck" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </div>

</asp:Content>


