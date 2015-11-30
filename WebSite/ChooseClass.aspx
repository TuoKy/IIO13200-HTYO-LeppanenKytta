<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChooseClass.aspx.cs" Inherits="ChooseClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div = id="container">
        <asp:Button ID="druidCards"  runat="server" Text="Druid" class="btn btn-default" BackColor="#996633" ForeColor="White" OnClick="druidCards_Click" />
        <asp:Button ID="hunterCards" runat="server" Text="Hunter"   class="btn btn-default" BackColor="#009933" ForeColor="White" />
        <asp:Button ID="mageCards" runat="server" Text="Mage"   class="btn btn-default" BackColor="#33CCFF"/>
        <asp:Button ID="paladinCards" runat="server" Text="Paladin"   class="btn btn-default" BackColor="Yellow"/>
        <asp:Button ID="priestCards" runat="server" Text="Priest"   class="btn btn-default"/>
        <asp:Button ID="rogueCards" runat="server" Text="Rogue"   class="btn btn-default" BackColor="#666666" ForeColor="White"/>
        <asp:Button ID="shamanCards" runat="server" Text="Shaman"   class="btn btn-default" BackColor="Blue" ForeColor="White"/>
        <asp:Button ID="warlockCards" runat="server" Text="Warlock"  class="btn btn-default" BackColor="#660066" ForeColor="White"/>
        <asp:Button ID="warriorCards" runat="server" Text="Warrior"  class="btn btn-default" BackColor="Red" ForeColor="White"/>
    </div>
</asp:Content>

