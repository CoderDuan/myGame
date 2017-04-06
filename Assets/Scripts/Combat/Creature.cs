using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Creature {

    public string name;
    public int health;
    public int mana;
    public int action;

    protected List<Card> deck;
    protected List<Card> deckTemp;
    protected List<Card> hand;
    protected List<Card> table;
    protected List<Card> discard;

    // Use this for initialization
    public Creature (string nameString, int hp, int mp, int ap) {
        name = nameString;
        health = hp;
        mana = mp;
        action = ap;
	}

    public bool TakeDamage(int damage, DamageTypes damageType)
    {
        if (damage > 0)
        {
            health -= damage;
            return true;
        } else
        {
            return false;
        }
    }
}
