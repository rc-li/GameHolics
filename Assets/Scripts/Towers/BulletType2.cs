using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType2 : Bullet
{
    void Start()
    {
        speed = Cards.cardProperties["TowerType2"].speed;
        slowPercent = Cards.cardProperties["TowerType2"].slowPercent;
        damage = Cards.cardProperties["TowerType2"].damage;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
        target.GetComponent<Enemy>().SlowDown(slowPercent);
    }
}
