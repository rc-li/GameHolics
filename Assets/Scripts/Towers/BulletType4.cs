using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType4 : Bullet
{
    void Start()
    {
        speed = Cards.cardProperties["TowerType4"].speed;
        damage = Cards.cardProperties["TowerType4"].damage;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().WalkBack(true);
    }
}
