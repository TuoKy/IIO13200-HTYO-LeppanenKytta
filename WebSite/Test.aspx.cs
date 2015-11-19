using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using unirest_net.http;
using Newtonsoft.Json;

public partial class Test : System.Web.UI.Page
{
    //Ei toimi tällä hetkellä
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpResponse<string> response = Unirest.get("https://omgvamp-hearthstone-v1.p.mashape.com/cards")
        .header("X-Mashape-Key", "????")
        .asJson<string>();


        //JavaScriptSerializer ser = new JavaScriptSerializer();
        //CardDeck plaa = ser.Deserialize<CardDeck>(response.Body);

        CardDeck plaa = new CardDeck();
        plaa = JsonConvert.DeserializeObject<CardDeck>(response.Body);

        //IEnumerable<string> sorsa = response as IEnumerable<string>;
        Label1.Text = response.Body;
        
        //for ()

        //Grid.DataSource = sorsa;

    }
}