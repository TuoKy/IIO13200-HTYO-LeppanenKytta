using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private CardLogic logic;
    private List<Card> temp;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            logic = new CardLogic();
            Session["logic"] = logic;
            logic.divideAndConquer("Warrior", 689);
            //logic.divideAndConquer("Druid", 305);
            temp = logic.smallCardPool;
            setPictures(logic.index);
        }
        else
        {
            logic = (CardLogic)(Session["logic"]);
            //Session["preLoads"] = logic.preloadNextImages();
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
            setPictures(logic.index - 15);
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void druidCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Druid", 305);
        setPictures(logic.index);
    }

    protected void hunterCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Hunter", 354);
        setPictures(logic.index);
    }

    protected void mageCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Mage",  400);
        setPictures(logic.index);
    }

    protected void paladinCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Paladin", 430);
        setPictures(logic.index);
    }

    protected void priestCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Priest", 460);
        setPictures(logic.index);
    }

    protected void rogueCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Rogue", 490);
        setPictures(logic.index);
    }

    protected void shamanCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Shaman", 520);
        setPictures(logic.index);
    }
    protected void warlockCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Warlock", 550);
        setPictures(logic.index);
    }

    protected void warriorCards_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("Warrior", 580);
        setPictures(logic.index);
    }

    protected void neutrals_Click(object sender, EventArgs e)
    {
        logic.divideAndConquer("", 0);
        setPictures(logic.index);
    }


}