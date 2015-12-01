<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BrowseDecks.aspx.cs" Inherits="BrowseDecks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="container">

    <div id="allDecks">
            <asp:UpdatePanel runat="server" ID="Updatepanel2">
                <ContentTemplate>
                    <asp:GridView ID="GridViewDeck" runat="server"
                        AutoGenerateColumns="False"
                        CssClass="table table-striped table-bordered table-condensed"
                        OnRowCommand="GridViewDeck_RowCommand" >

                        <Columns>
                            <asp:BoundField DataField="name" HeaderText="Name" ReadOnly="True" />
                            <asp:BoundField DataField="playerClass" HeaderText="Class" />
                            <asp:BoundField DataField="cardCount" HeaderText="Card Count" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="lnkView" CommandArgument='<%#Eval("name") %>'
                                        CommandName="VIEW">View</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>              
</asp:Content>

