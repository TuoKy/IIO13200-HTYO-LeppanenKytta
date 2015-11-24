using Newtonsoft.Json;
using System.Collections.Generic;

public class Card
{
    public string cardId { get; set; }
    public string name { get; set; }
    public string cardSet { get; set; }
    public string type { get; set; }
    public string rarity { get; set; }
    public int cost { get; set; }
    public int attack { get; set; }
    public int health { get; set; }
    public string text { get; set; }  
    public string playerClass { get; set; }
    public string img { get; set; }
    
}
public class CardCollection
{
    [JsonProperty("Basic")]
    public List<Card> basic { get; set; }

    [JsonProperty("Classic")]
    public List<Card> classic { get; set; }

    [JsonProperty("Naxxramas")]
    public List<Card> naxxramas { get; set; }

    [JsonProperty("Goblins vs Gnomes")]
    public List<Card> gvg { get; set; }

    [JsonProperty("Blackrock Mountain")]
    public List<Card> blackrock { get; set; }

    [JsonProperty("The Grand Tournament")]
    public List<Card> grandTournament { get; set; }

    [JsonProperty("The League of Explorers")]
    public List<Card> leagueOfExplorers { get; set; }

}