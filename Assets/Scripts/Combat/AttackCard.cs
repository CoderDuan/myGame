using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class AttackCard : Card
{
    protected int damage;
    protected DamageTypes damageType = DamageTypes.PHYSICAL;

    public AttackCard(string name)
        : base(name)
    {

    }
}

