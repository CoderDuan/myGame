using UnityEngine;
using System.Collections;

public class Attack1 : AttackCard {

    public Attack1() : base("Attack1")
    {
        damage = 1;
    }

    public override bool Use(Creature self, Creature opponent)
    {
        return PhysicalAttack(opponent, damage);
    }
}
