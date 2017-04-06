using UnityEngine;
using System.Collections;

public class Attack1 : AttackCard {

    public Attack1() : base("Attack1")
    {
        damage = 1;
    }

    public override bool use(Creature self, Creature opponent)
    {
        return opponent.TakeDamage(damage, damageType);
    }
}
