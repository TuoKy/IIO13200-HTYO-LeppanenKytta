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
        HttpResponse<string> response = Unirest.get("https://omgvamp-hearthstone-v1.p.mashape.com/cards?collectible=1")
        .header("X-Mashape-Key", "???")
        .asJson<string>();

        CardCollection plaa = new CardCollection();
        plaa = JsonConvert.DeserializeObject<CardCollection>(response.Body);

        List<Card> cards = new List<Card>();
        cards.AddRange(plaa.basic);
        cards.AddRange(plaa.classic);
        cards.AddRange(plaa.naxxramas);
        cards.AddRange(plaa.gvg);
        cards.AddRange(plaa.blackrock);
        cards.AddRange(plaa.grandTournament);
        cards.AddRange(plaa.leagueOfExplorers);
      
          

        Grid.DataSource = cards as IEnumerable<Card>;
        Grid.DataBind();
    }
}