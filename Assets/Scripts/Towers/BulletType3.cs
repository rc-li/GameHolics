using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType3 : Bullet
{
    void Start()
    {
        speed = Cards.cardProperties["TowerType3"].speed;
        damage = Cards.cardProperties["TowerType3"].damage;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
    }
}
