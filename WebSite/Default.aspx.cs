using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private CardLogic logic;   
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {                        
            logic = new CardLogic();
            setPictures(logic.index);
        }       
    }
    
    private void setPictures(int i)
    {
        Image1.ImageUrl = logic.cards[i].img;
        Image2.ImageUrl = logic.cards[i + 1].img;
        Image3.ImageUrl = logic.cards[i + 2].img;
        Image4.ImageUrl = logic.cards[i + 3].img;
        Image5.ImageUrl = logic.cards[i + 4].img;
        Image6.ImageUrl = logic.cards[i + 5].img;
        Image7.ImageUrl = logic.cards[i + 6].img;
        Image8.ImageUrl = logic.cards[i + 7].img;

        logic.index = i + 7;
    }

    protected void next_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            setPictures(logic.index + 1);
        }
        catch (Exception)
        {

            throw;
        }
        
    }

    protected void previous_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            setPictures(logic.index - 8);
        }
        catch (Exception)
        {

            throw;
        }
    }

}