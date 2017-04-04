using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Creature {

    public string name;
    public int health;
    public int mana;
    public int action;

    private List<Card> deck;

    // Use this for initialization
    Creature (string nameString, int hp, int mp, int ap) {
        name = nameString;
        health = hp;
        mana = mp;
        action = ap;
	}
}
