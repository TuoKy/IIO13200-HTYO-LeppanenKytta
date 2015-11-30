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

    protected void druidCards_Click(object sender, EventArgs e)
    {
        Session["class"] = "Druid";
        Response.Redirect("CreateDeck.aspx");
    }
}