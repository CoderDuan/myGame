using UnityEngine;
using System.Collections;

public enum CardType
{
    ATTACK = 0,
    DEFENCE,
    TACTICAL,
    SPELL,
    MANA,
};

public class Card {

    private string name;
    private CardType cardType;

    public Card(string name)
    {

    }


}
