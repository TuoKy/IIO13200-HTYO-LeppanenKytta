using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using unirest_net.http;

public partial class Test : System.Web.UI.Page
{
    //Ei toimi tällä hetkellä
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpResponse<Card> response = Unirest.get("https://omgvamp-hearthstone-v1.p.mashape.com/cards")
        .header("X-Mashape-Key", "notToday")
        .asJson<Card>();

        IEnumerable<Card> sorsa = response.Body as IEnumerable<Card>;

        Label1.Text = response.Body.ToString();

        Grid.DataSource = sorsa;

    }
}