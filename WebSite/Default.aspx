<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div = id="container">
    <div id="navigationTop">
        <asp:Button ID="druidCards" runat="server" Text="Druid" OnClick="druidCards_Click" BackColor="#996633" ForeColor="Black" />
        <asp:Button ID="hunterCards" runat="server" Text="Hunter" OnClick="hunterCards_Click" BackColor="#33CC33" />
        <asp:Button ID="mageCards" runat="server" Text="Mage" OnClick="mageCards_Click" BackColor="#3399FF" />
        <asp:Button ID="paladinCards" runat="server" Text="Paladin" OnClick="paladinCards_Click" BackColor="Yellow" />
        <asp:Button ID="priestCards" runat="server" Text="Priest" OnClick="priestCards_Click" BackColor="White" />
        <asp:Button ID="rogueCards" runat="server" Text="Rogue" OnClick="rogueCards_Click" BackColor="#666699" />
        <asp:Button ID="shamanCards" runat="server" Text="Shaman" OnClick="shamanCards_Click" BackColor="Blue" />
        <asp:Button ID="warlockCards" runat="server" Text="Warlock" OnClick="warlockCards_Click" BackColor="#660066" />
        <asp:Button ID="warriorCards" runat="server" Text="Warrior" OnClick="warriorCards_Click" BackColor="Red" />
        <asp:Button ID="neutrals" runat="server" Text="Neutrals" OnClick="neutrals_Click" BackColor="#CC9900" />
    </div>

    <div id="cards"> 
     <asp:ImageButton ID="previous" runat="server" ImageUrl="Images/arrowBack.png" CssClass="arrowStyleLeft" OnClick="previous_Click" />                                                        
         <asp:updatepanel runat="server" id="panel">
            <Triggers>              
                <asp:AsyncPostBackTrigger ControlID="druidCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="hunterCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="mageCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="paladinCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="priestCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="rogueCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="shamanCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="warlockCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="warriorCards" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="neutrals" EventName="Click" />
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
     <asp:ImageButton ID="next" runat="server" ImageUrl="Images/arrowNext.png" CssClass="arrowStyleRight" onClick="next_Click" /> 
    </div> 
   
    </div>           
</asp:Content>


