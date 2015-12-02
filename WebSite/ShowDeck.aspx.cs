using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowDeck : System.Web.UI.Page
{
    private CardLogic logic;

    protected void Page_Load(object sender, EventArgs e)
    {
        logic = new CardLogic();
        logic.setDecks(1);
        int deckId = (int)Session["deckId"];
        int deckIndex = logic.decks.FindIndex(x => x.deckId == deckId);
        logic.setCardsInActiveDeck(deckId);

        deckName.Text = "Deck Name: " + logic.decks[deckIndex].name;
        deckClass.Text = "Deck Class: " + logic.decks[deckIndex].playerClass;



        List<String> filePaths = logic.getCardImageUrls();
        cardRepeater.DataSource = filePaths;
        cardRepeater.DataBind();

    }
}