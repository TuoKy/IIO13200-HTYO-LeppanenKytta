<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChooseClass.aspx.cs" Inherits="ChooseClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div = id="container">
        <asp:Button ID="druidCards"  runat="server" Text="Druid" class="btn btn-default classButton" BackColor="#996633" ForeColor="White" OnClick="button_Click" />
        <asp:Button ID="hunterCards" runat="server" Text="Hunter"   class="btn btn-default classButton" BackColor="#009933" ForeColor="White" OnClick="button_Click" />
        <asp:Button ID="mageCards" runat="server" Text="Mage"   class="btn btn-default classButton" BackColor="#33CCFF" ForeColor="White" OnClick="button_Click"/>
        <asp:Button ID="paladinCards" runat="server" Text="Paladin"   class="btn btn-default classButton" BackColor="Yellow" OnClick="button_Click"/>
        <asp:Button ID="priestCards" runat="server" Text="Priest"   class="btn btn-default classButton" OnClick="button_Click"/>
        <asp:Button ID="rogueCards" runat="server" Text="Rogue"   class="btn btn-default classButton" BackColor="#666666" ForeColor="White" OnClick="button_Click"/>
        <asp:Button ID="shamanCards" runat="server" Text="Shaman"   class="btn btn-default classButton" BackColor="Blue" ForeColor="White" OnClick="button_Click"/>
        <asp:Button ID="warlockCards" runat="server" Text="Warlock"  class="btn btn-default classButton" BackColor="#660066" ForeColor="White" OnClick="button_Click"/>
        <asp:Button ID="warriorCards" runat="server" Text="Warrior"  class="btn btn-default classButton" BackColor="Red" ForeColor="White" OnClick="button_Click"/>
    </div>
</asp:Content>

