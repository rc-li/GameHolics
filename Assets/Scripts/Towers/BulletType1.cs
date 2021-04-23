using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType1 : Bullet
{
    void Start()
    {
        speed = Cards.cardProperties["TowerType1"].speed;
        damage = Cards.cardProperties["TowerType1"].damage;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
    }
}
