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
            druidCards.Style["display"] = "none";
            hunterCards.Style["display"] = "none";
            mageCards.Style["display"] = "none";
            paladinCards.Style["display"] = "none";
            priestCards.Style["display"] = "none";
            rogueCards.Style["display"] = "none";
            shamanCards.Style["display"] = "none";
            warlockCards.Style["display"] = "none";
            warriorCards.Style["display"] = "none";

            String classButtonName = ((string)(Session["class"])).ToLower() + "Cards";
            Button button = this.Master.FindControl("ContentPlaceHolder1").FindControl(classButtonName) as Button;
            if (button != null)
            {
                button.Style["display"] = "visible";
            }

            if (Session["logic"] == null)
            {
                logic = new CardLogic();
                Session["logic"] = logic;
            }
            else
                logic = (CardLogic)Session["logic"];

            Session["cardsInDeck"] = logic.cardsInDeck;
            //User id pitää vaihtaa kun saa loginin tehtyä
           // logic.startDeck((string)(Session["class"]),1);
            logic.divideAndConquer((string)(Session["class"]));
            setPictures(logic.index);
            GridViewDeck.DataSource = logic.cardsInDeck as IEnumerable<Card>;
            GridViewDeck.DataBind();
        }
        else
        {
            logic = (CardLogic)(Session["logic"]);
            logic.cardsInDeck = (List<Card>)(Session["cardsInDeck"]);
            GridViewDeck.DataSource = logic.cardsInDeck as IEnumerable<Card>;
            GridViewDeck.DataBind();
        }
    }

    private void setPictures(int i)
    {
        Image1.ImageUrl = logic.smallCardPool[i].img;
        Image1.AlternateText = logic.smallCardPool[i].cardId.ToString();
        Image2.ImageUrl = logic.smallCardPool[i + 1].img;
        Image2.AlternateText = logic.smallCardPool[i + 1].cardId.ToString();
        Image3.ImageUrl = logic.smallCardPool[i + 2].img;
        Image3.AlternateText = logic.smallCardPool[i + 2].cardId.ToString();
        Image4.ImageUrl = logic.smallCardPool[i + 3].img;
        Image4.AlternateText = logic.smallCardPool[i + 3].cardId.ToString();
        Image5.ImageUrl = logic.smallCardPool[i + 4].img;
        Image5.AlternateText = logic.smallCardPool[i + 4].cardId.ToString();
        Image6.ImageUrl = logic.smallCardPool[i + 5].img;
        Image6.AlternateText = logic.smallCardPool[i + 5].cardId.ToString();
        Image7.ImageUrl = logic.smallCardPool[i + 6].img;
        Image7.AlternateText = logic.smallCardPool[i + 6].cardId.ToString();
        Image8.ImageUrl = logic.smallCardPool[i + 7].img;
        Image8.AlternateText = logic.smallCardPool[i + 7].cardId.ToString();

        logic.index = i + 7;
    }

    protected void GridViewDeck_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        
        if (e.CommandName == "DELETE")
        {
            LinkButton lnkDelete = (LinkButton)e.CommandSource;
            //int index = Convert.ToInt32(lnkDelete.CommandArgument);
            int temp = logic.cardsInDeck.FindIndex(x => x.name == lnkDelete.CommandArgument);
            String temp2 = logic.cardsInDeck[temp].cardId;
            logic.deleteCard(temp2);
            Updatepanel2.Update();
        }
    }

    protected void classButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.Text;

        if(buttonId == "Neutrals")
        {
            buttonId = "";
        }

        logic.divideAndConquer(buttonId);
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


    protected void ImageButtonClick(object sender, ImageClickEventArgs e)
    {
        ImageButton tempButton = (ImageButton)sender;
        //Tähän voi asettaa jotain tarkistuksia alternateText kentälle
        if(!logic.addCard(tempButton.AlternateText))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Kortin lisäys epäonnistui!');", true);
        }
        GridViewDeck.DataBind();
    }

    protected void SaveButtonClick(object sender, EventArgs e)
    {
        string tempName = deckName.Text;

        if(tempName != "")
        {
            logic.saveDeck(tempName);
            Response.Redirect("Default.aspx");
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Pakan nimi puuttuu.');", true);
        }
    }

    protected void lnkDelete_Load(object sender, EventArgs e)
    {
        LinkButton btn = (LinkButton)sender;
        Updatepanel2.Triggers.Add(new AsyncPostBackTrigger { ControlID = btn.UniqueID, EventName="Click"});
    }
}