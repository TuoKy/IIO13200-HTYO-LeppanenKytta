using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BrowseDecks : System.Web.UI.Page
{
    private CardLogic logic;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logic"] == null)
        {
            logic = new CardLogic();
            Session["logic"] = logic;
        }
        else
            logic = (CardLogic)Session["logic"];

        logic.setDecks(1);
        GridViewDeck.DataSource = logic.decks as IEnumerable<Deck>;
        GridViewDeck.DataBind();
    }

    protected void GridViewDeck_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "VIEW")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            Deck temp = logic.decks.Find(x => x.name == lnkView.CommandArgument);
            Session["deckId"] = temp.deckId;
            Response.Redirect("ShowDeck.aspx");
        }
    }
}