<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowDeck.aspx.cs" Inherits="ShowDeck" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <div id="deckDetails">
            <asp:label runat="server" ID="deckName"></asp:label>
            <br />
            <asp:label runat="server" ID="deckClass"></asp:label>
            <br />
        </div>

        <div id="CurrentDeck">

            <asp:GridView ID="GridViewDeck" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-striped table-bordered table-condensed">

                <Columns>
                    <asp:ImageField DataImageUrlField="img"></asp:ImageField>
                    <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" />
                    <asp:BoundField DataField="cost" HeaderText="cost" />
                    <asp:BoundField DataField="attack" HeaderText="attack" />
                    <asp:BoundField DataField="health" HeaderText="health" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

