<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <asp:scriptmanager runat="server"></asp:scriptmanager>
    
    <div id="navigationTop">
        <asp:updatepanel runat="server">
            <ContentTemplate> 
               <asp:Button ID="druidCards" runat="server" Text="Druid" OnClick="druidCards_Click" />
               <asp:Button ID="hunterCards" runat="server" Text="Hunter" OnClick="hunterCards_Click" />
               <asp:Button ID="mageCards" runat="server" Text="Mage" OnClick="mageCards_Click" />
               <asp:Button ID="paladinCards" runat="server" Text="Paladin" OnClick="paladinCards_Click" />
               <asp:Button ID="priestCards" runat="server" Text="Priest" OnClick="priestCards_Click" />
               <asp:Button ID="rogueCards" runat="server" Text="Rogue" OnClick="rogueCards_Click" />
               <asp:Button ID="shamanCards" runat="server" Text="Shaman" OnClick="shamanCards_Click" />
               <asp:Button ID="warlockCards" runat="server" Text="Warlock" OnClick="warlockCards_Click" />
               <asp:Button ID="warriorCards" runat="server" Text="Warrior" OnClick="warriorCards_Click" />
               <asp:Button ID="neutrals" runat="server" Text="Neutrals" OnClick="neutrals_Click" />
            </ContentTemplate> 
        </asp:updatepanel> 
    </div>
                                 
    <div id="cards">                        
        <asp:updatepanel runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="druidCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="hunterCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="paladinCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="priestCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="rogueCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="shamanCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="warlockCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="warriorCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="neutrals" EventName="Click" />
            </Triggers>
            <ContentTemplate>  
            <asp:ImageButton ID="previous" runat="server" ImageUrl="Images/arrowBack.png" CssClass="arrowStyleLeft" OnClick="previous_Click" />                      
            <asp:Image ID="Image1" runat="server" CssClass="imageStyle"/>
            <asp:Image ID="Image2" runat="server" CssClass="imageStyle"/>
            <asp:Image ID="Image3" runat="server" CssClass="imageStyle"/>
            <asp:Image ID="Image4" runat="server" CssClass="imageStyle"/>
         
            <asp:Image ID="Image5" runat="server" CssClass="imageStyle"/>
            <asp:Image ID="Image6" runat="server" CssClass="imageStyle"/>
            <asp:Image ID="Image7" runat="server" CssClass="imageStyle"/>
            <asp:Image ID="Image8" runat="server" CssClass="imageStyle"/>
            <asp:ImageButton ID="next" runat="server" ImageUrl="Images/arrowNext.png" CssClass="arrowStyleRight" onClick="next_Click" />                                                        
            </ContentTemplate>
        </asp:updatepanel>                                          
    </div>
                
    <div id="buttonsSide">
        <asp:Button ID="Create" runat="server" Text="Create new deck" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </div>

</asp:Content>


