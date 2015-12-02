<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowDeck.aspx.cs" Inherits="ShowDeck" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <div id="deckDetails">
            <asp:label runat="server" ID="deckName" Font-Size="Medium" class="label label-default"></asp:label>
            <br />
            <br />
            <asp:label runat="server" ID="deckClass" Font-Size="Medium" class="label label-default"></asp:label>
            <br />
        </div>

        <div>

            <asp:Repeater ID="cardRepeater" runat="server">
                <ItemTemplate>
                    <div style="display: inline;">
                        <img src="<%# Container.DataItem %>" height="350" width="225" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>
</asp:Content>

