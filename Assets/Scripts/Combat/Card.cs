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

public abstract class Card
{

    protected string name;
    protected CardType cardType;

    public Card(string name)
    {

    }

    // Creature c1 uses this card against Creature c2
    public abstract bool use(Creature self, Creature opponent);
}
