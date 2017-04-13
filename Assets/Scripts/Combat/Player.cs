using UnityEngine;
using System.Collections;

public class Player : Creature {

    public Player(int hp, int mp, int ap, int handsize)
        : base("player", hp, mp, ap, handsize)
    {
        originalDeck.Clear();
    }
}
