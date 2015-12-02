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
    protected void Page_Load(object sender, EventArgs e)
    {
        
        HttpResponse<string> response = Unirest.get("https://omgvamp-hearthstone-v1.p.mashape.com/cards?collectible=1")
        .header("X-Mashape-Key", "Y6G2Ve8iAOmshQFq4sGVgvBtI1HVp1CVLrWjsnPikTu4oqy2EK")
        .asJson<string>();

        CardCollection collection = new CardCollection();
        collection = JsonConvert.DeserializeObject<CardCollection>(response.Body);
        
        List<Card> cards = new List<Card>();
        cards.AddRange(collection.basic);
        cards.AddRange(collection.classic);
        cards.AddRange(collection.naxxramas);
        cards.AddRange(collection.gvg);
        cards.AddRange(collection.blackrock);
        cards.AddRange(collection.grandTournament);
        cards.AddRange(collection.leagueOfExplorers);
        
        DataAccessLayer layer1 = new DataAccessLayer();
        
        try
        {
            layer1.InsertCardsToDb(cards);
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Kortit jo kannassa');", true);
        }
        


        //Grid.DataSource = cards as IEnumerable<Card>;
        Grid.DataSource = cards as IEnumerable<Card>;
        Grid.DataBind();
    }
}