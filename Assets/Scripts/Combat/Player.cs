using UnityEngine;
using System.Collections;

public class Player : Creature {

    public Player(int hp, int mp, int ap)
        : base("player", hp, mp, ap)
    {
        this.deck.Clear();
    }
}
