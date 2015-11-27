using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Deck
/// </summary>
public class Deck
{
    public int deckId { get; set; }
    public string name { get; set; }
    public int userId { get; set; }
    public List<deckHasCard> cards { get; set; }
}

public class deckHasCard
{
    public int cardId { get; set; }
    public int count { get; set; }
}