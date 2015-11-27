using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CardLogic
/// </summary>
public class CardLogic
{
    

    public CardLogic()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    
}

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