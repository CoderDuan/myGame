using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DeckOfAll
{
    public static DeckOfAll instance = null;

    public Dictionary<string, Card> cards = new Dictionary<string, Card>();

    protected DeckOfAll()
    {
        cards.Add("Attack1", new Attack1());
    }

    public static DeckOfAll getInstance()
    {
        if (instance == null)
            instance = new DeckOfAll();
        return instance;
    }
}
