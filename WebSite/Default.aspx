<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="navigationTop">
       <asp:Button ID="druidCards" runat="server" Text="Druid" />
       <asp:Button ID="hunterCards" runat="server" Text="Hunter" />
       <asp:Button ID="mageCards" runat="server" Text="Mage" />
       <asp:Button ID="paladinCards" runat="server" Text="Paladin" />
       <asp:Button ID="priestCards" runat="server" Text="Priest" />
       <asp:Button ID="rogueCards" runat="server" Text="Rogue" />
       <asp:Button ID="shamanCards" runat="server" Text="Shaman" />
       <asp:Button ID="warriorCards" runat="server" Text="Warrior" />
       <asp:Button ID="neutrals" runat="server" Text="Neutrals" />
    </div>
        
    <asp:scriptmanager runat="server"></asp:scriptmanager>
                   
            <div id="cards">         
                <asp:ImageButton ID="previous" runat="server" ImageUrl="Images/arrowBack.png" CssClass="arrowStyleLeft" OnClick="previous_Click" />
                <asp:updatepanel runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="previous" EventName="Click" />
                        <asp:AsyncPostBackTrigger ControlID="next" EventName="Click" />
                    </Triggers>
                    <ContentTemplate>                    
                    <asp:Image ID="Image1" runat="server" CssClass="imageStyle"/>
                    <asp:Image ID="Image2" runat="server" CssClass="imageStyle"/>
                    <asp:Image ID="Image3" runat="server" CssClass="imageStyle"/>
                    <asp:Image ID="Image4" runat="server" CssClass="imageStyle"/>
                 
                    <asp:Image ID="Image5" runat="server" CssClass="imageStyle"/>
                    <asp:Image ID="Image6" runat="server" CssClass="imageStyle"/>
                    <asp:Image ID="Image7" runat="server" CssClass="imageStyle"/>
                    <asp:Image ID="Image8" runat="server" CssClass="imageStyle"/>                     
                    </ContentTemplate>
                </asp:updatepanel>            
                <asp:ImageButton type="button" ID="next" runat="server" ImageUrl="Images/arrowNext.png" CssClass="arrowStyleRight" onClick="next_Click" />               
            </div>
        
        
    <div id="buttonsSide">
        <asp:Button ID="Create" runat="server" Text="Create new deck" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </div>

</asp:Content>


