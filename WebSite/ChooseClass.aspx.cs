using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChooseClass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.Text;

        Session["class"] = buttonId;
        Response.Redirect("CreateDeck.aspx");
    }
}