using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateDeck : System.Web.UI.Page
{
    private CardLogic logic;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            logic = new CardLogic();
            Session["logic"] = logic;
            logic.divideAndConquer("Druid");
            setPictures(logic.index);
        }
        else
        {
            logic = (CardLogic)(Session["logic"]);
        }
    }

    private void setPictures(int i)
    {
        Image1.ImageUrl = logic.smallCardPool[i].img;
        Image2.ImageUrl = logic.smallCardPool[i + 1].img;
        Image3.ImageUrl = logic.smallCardPool[i + 2].img;
        Image4.ImageUrl = logic.smallCardPool[i + 3].img;
        Image5.ImageUrl = logic.smallCardPool[i + 4].img;
        Image6.ImageUrl = logic.smallCardPool[i + 5].img;
        Image7.ImageUrl = logic.smallCardPool[i + 6].img;
        Image8.ImageUrl = logic.smallCardPool[i + 7].img;

        logic.index = i + 7;
    }

    protected void druidCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Druid");
        setPictures(logic.index);
    }

    protected void hunterCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Hunter");
        setPictures(logic.index);
    }

    protected void mageCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Mage");
        setPictures(logic.index);
    }

    protected void paladinCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Paladin");
        setPictures(logic.index);
    }

    protected void priestCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Priest");
        setPictures(logic.index);
    }

    protected void rogueCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Rogue");
        setPictures(logic.index);
    }

    protected void shamanCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Shaman");
        setPictures(logic.index);
    }
    protected void warlockCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Warlock");
        setPictures(logic.index);
    }

    protected void warriorCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Warrior");
        setPictures(logic.index);
    }

    protected void neutrals_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("");
        setPictures(logic.index);
    }

    protected void previous_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            setPictures(logic.index - 15);
        }
        catch (Exception)
        {
           
        }
    }

    protected void next_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            setPictures(logic.index + 1);
        }
        catch (Exception)
        {
            
        }
    }
}