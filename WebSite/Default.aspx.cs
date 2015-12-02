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

        //Logic olio tallennetaan sessiooon että sinne tallennettuja tietoja voidaan käyttää sivun
        //uudelleen rakentumisen jälkeen
        if (!IsPostBack)
        {
            if (Session["logic"] == null)
            {
                logic = new CardLogic();
                Session["logic"] = logic;
            }
            else
                logic = (CardLogic)Session["logic"];
            logic.divideAndConquer("Druid");
            setPictures(logic.index);
        }
        else
        {
            logic = (CardLogic)(Session["logic"]);
        }     
    }
    

    //Temp ratkaisu muuttaa 8 seuraavan kuvan imageurlia
    //Update, ei ksokaan muutettu jäi final solutioniksi
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
    
    //Hienot kontrollit nuolille
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

    protected void classButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.Text;

        if (buttonId == "Neutrals")
        {
            buttonId = "";
        }

        logic.divideAndConquer(buttonId);
        setPictures(logic.index);
    }
}