using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Kaikki bisneslogiikan kaltainen joka liittyy korttien käyttöön
/// </summary>
public class CardLogic
{
    public int index { get; set; }
    public List<Card> cards { get; set; }
    public List<Card> smallCardPool { get; set; }
    
     public List<Deck> decks { get; set; }
     //Kortit joita on aktiivisessa muokkauksessa
     public List<Card> cardsInDeck { get; set; }   
    public Deck newDeck { get; set; }
    //Kortit joita on valitussa pakassa via browse deck
    public List<Card> cardsInSelectedDeck { get; set; }

    private DataAccessLayer layer = new DataAccessLayer();

    public CardLogic()
    {
        index = 0;
        cards = getCards();
        smallCardPool = new List<Card>();
        cardsInDeck = new List<Card>();
        cardsInSelectedDeck = new List<Card>();
        newDeck = new Deck();
        newDeck.cards = new List<deckHasCard>();
    }

    public void startDeck(string playerClass, int userId)
    {
        //Asetetaan käyttäjä ja korttien luokka
        newDeck.userId = userId;
        newDeck.playerClass = playerClass;
        newDeck.cardCount = 0;
        //Alustetaan tiedot joita ei vielä ole
        newDeck.name = "";
        newDeck.cards.Clear();
        //Näytöllä näytettävät valittujen korttien tiedot tähän listaan
        cardsInDeck.Clear();
    }

    public bool addCard(string cardId)
    {
        if (newDeck.cardCount < 30)
        {
            int index = newDeck.cards.FindIndex(x => x.cardId == cardId);
            if (index == -1)
            {
                newDeck.cards.Add(new deckHasCard
                {
                    cardId = cardId,
                    count = 1
                });
            }
            else if (newDeck.cards[index].count == 1)
            {
                newDeck.cards[index].count = 2;
            }
            else
            {
                return false;
            }
            newDeck.cardCount++;
            cardsInDeck.Add(cards.Find(x => x.cardId == cardId));
            cardsInDeck.Sort(new cardComparer());
            return true;
        }
        else
        {
            return false;
        }
    }

    public void deleteCard(string cardId)
    {
        int index = newDeck.cards.FindIndex(x => x.cardId == cardId);
        if (index >= 0)
        {
            newDeck.cardCount--;
            cardsInDeck.RemoveAt(cardsInDeck.FindIndex(x => x.cardId == cardId));
            if (newDeck.cards[index].count == 1)
            {
                newDeck.cards.RemoveAt(index);
            }
            else if (newDeck.cards[index].count == 2)
            {
                newDeck.cards[index].count = 1;
            }
        }
    }

    public void saveDeck(string deckName)
    {
        newDeck.name = deckName;
        layer.writeDeckToDB(newDeck);
    }

    public void setDecks(int userId)
    {
        decks = layer.readAllUserDecksFromDB(userId);
    }

    //Settaa kortit muokattavaan pakkaan
    public void setCardsInActiveDeck(int deckId)
    {
        cardsInSelectedDeck.Clear();

        foreach (var item in decks.Find(x => x.deckId == deckId).cards)
        {
            for (int i = 0; i<item.count; i++)
            {
                cardsInSelectedDeck.Add(cards.Find(x => x.cardId == item.cardId));
            }
        }
     }

    public List<String> getCardImageUrls()
    {
        List<String> tempUrls = new List<String>();
        int index = 0;

        cardsInSelectedDeck.Sort(new cardComparer());

        foreach(Card item in cardsInSelectedDeck)
        {
            tempUrls.Add(item.img);
            index++;
        }
        return tempUrls;
    }

    //Hae kortit
    private List<Card> getCards()
    {
        List<Card> temp = new List<Card>();

        try
        {
            temp = layer.readCardsFromDB();
            temp.Sort(new cardComparer());
            return temp;
        }
        catch (Exception)
        {
            throw;
        }
    }
    //Otetaan pieni osa korteista käsiteltäväksi
    public void divideAndConquer(string name)
    {
        smallCardPool = cards.FindAll(x => x.playerClass == name);
        index = 0;
    }
}
//Lajitellaan kortit luokan ja manacostin mukaan
public class cardComparer : IComparer<Card>
{
    public int Compare(Card x, Card y)
    {
        if (string.Compare(x.playerClass, y.playerClass) == 0)
        {
            if (x.cost > y.cost)
                return 1;
            else if (x.cost < y.cost)
                return -1;
            else
                return 0;
        }
        else if (string.Compare(x.playerClass, y.playerClass) == 1)
            return 1;
        else
            return -1;
    }
}