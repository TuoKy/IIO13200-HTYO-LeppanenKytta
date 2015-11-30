<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateDeck.aspx.cs" Inherits="CreateDeck" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="container">
        <div id="navigationTop">
            <asp:Button ID="druidCards" runat="server" Text="Druid" OnClick="druidCards_Click" class="btn btn-default" BackColor="#996633" ForeColor="White" />
            <asp:Button ID="hunterCards" runat="server" Text="Hunter" OnClick="hunterCards_Click"  class="btn btn-default" BackColor="#009933" ForeColor="White" />
            <asp:Button ID="mageCards" runat="server" Text="Mage" OnClick="mageCards_Click"  class="btn btn-default" BackColor="#33CCFF"/>
            <asp:Button ID="paladinCards" runat="server" Text="Paladin" OnClick="paladinCards_Click"  class="btn btn-default" BackColor="Yellow"/>
            <asp:Button ID="priestCards" runat="server" Text="Priest" OnClick="priestCards_Click"  class="btn btn-default"/>
            <asp:Button ID="rogueCards" runat="server" Text="Rogue" OnClick="rogueCards_Click"  class="btn btn-default" BackColor="#666666" ForeColor="White"/>
            <asp:Button ID="shamanCards" runat="server" Text="Shaman" OnClick="shamanCards_Click"  class="btn btn-default" BackColor="Blue" ForeColor="White"/>
            <asp:Button ID="warlockCards" runat="server" Text="Warlock" OnClick="warlockCards_Click"  class="btn btn-default" BackColor="#660066" ForeColor="White"/>
            <asp:Button ID="warriorCards" runat="server" Text="Warrior" OnClick="warriorCards_Click" class="btn btn-default" BackColor="Red" ForeColor="White"/>
            <asp:Button ID="neutrals" runat="server" Text="Neutrals" OnClick="neutrals_Click"  class="btn btn-default" BackColor="#993300" ForeColor="White"/>
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
                <asp:ImageButton ID="Image1" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick" />   
                <asp:ImageButton ID="Image2" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick" />   
                <asp:ImageButton ID="Image3" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick"/>   
                <asp:ImageButton ID="Image4" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick"/>   
                
                <asp:ImageButton ID="Image5" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick"/>   
                <asp:ImageButton ID="Image6" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick"/>   
                <asp:ImageButton ID="Image7" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick"/>   
                <asp:ImageButton ID="Image8" runat="server" CssClass="imageStyle" OnClick="ImageButtonClick"/>                                                                           
                </ContentTemplate>
            </asp:updatepanel>                                                 
         <asp:ImageButton ID="next" runat="server" ImageUrl="Images/arrowNext.png" CssClass="arrowStyleRight" onClick="next_Click" /> 
        </div>
    
    </div> 
    <div id="anotherContainer">
        <div id="deckDetails">
            <asp:textbox runat="server" id="deckName"></asp:textbox>
            <asp:button runat="server" text="Save Deck" OnClick="SaveButtonClick" />
        </div>   

    <div id="CurrentDeck">
            <asp:UpdatePanel runat="server" ID="Updatepanel2">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Image1" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image2" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image3" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image4" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image5" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image6" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image7" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Image8" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="lnkDelete" EventName="GridViewDeck_RowCommand" />
                </Triggers>
                <ContentTemplate>
                    <asp:GridView ID="GridViewDeck" runat="server"
                        AutoGenerateColumns="False"
                        CssClass="table table-striped table-bordered table-condensed"
                        OnRowCommand="GridViewDeck_RowCommand" >

                        <Columns>
                            <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" />
                            <asp:BoundField DataField="cost" HeaderText="cost" />
                            <asp:BoundField DataField="attack" HeaderText="attack" />
                            <asp:BoundField DataField="health" HeaderText="health" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="lnkDelete" CommandArgument='<%#Eval("name") %>'
                                        CommandName="DELETE">Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>              
</asp:Content>

