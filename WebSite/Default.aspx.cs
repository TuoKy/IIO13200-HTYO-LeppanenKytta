using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private DataAccessLayer layer = new DataAccessLayer();
    private CardLogic logic = new CardLogic();
    List<Card> cards = new List<Card>();
    private IComparer<Card> comparer;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getCards();
            setPictures();
        }
        
    }

    private void getCards()
    {
        try
        {
            cards = layer.readCardsFromDB();
            cards.Sort(new cardComparer());
        }
        catch (Exception)
        {
            throw;
        }
    }

    private void setPictures()
    {
        Image1.ImageUrl = cards[0].img;
        Image2.ImageUrl = cards[1].img;
        Image3.ImageUrl = cards[2].img;
        Image4.ImageUrl = cards[3].img;
        Image5.ImageUrl = cards[4].img;
        Image6.ImageUrl = cards[5].img;
        Image7.ImageUrl = cards[6].img;
        Image8.ImageUrl = cards[7].img;

    }

}