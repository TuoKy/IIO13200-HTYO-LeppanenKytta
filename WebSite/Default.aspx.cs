using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private DataAccessLayer layer = new DataAccessLayer();
    List<Card> cards = new List<Card>();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getCards();

        }
    }

    private void getCards()
    {
        try
        {
            cards = layer.readCardsFromDB();
        }
        catch (Exception)
        {
            throw;
        }
    }

    private void setPictures()
    {

    }

}