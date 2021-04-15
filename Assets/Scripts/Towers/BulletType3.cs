using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType3 : Bullet
{
    void Start()
    {
        speed = 3.0f;
        damage = 100;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
    }
}
