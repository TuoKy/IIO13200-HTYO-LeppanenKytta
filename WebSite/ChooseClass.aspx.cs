using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChooseClass : System.Web.UI.Page
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
    }

    protected void button_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.Text;
        logic.startDeck(buttonId, 1);
        Session["logic"] = logic;
        Session["class"] = buttonId;
        Response.Redirect("CreateDeck.aspx");
    }
}