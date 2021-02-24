using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType1 : Bullet
{
    void Start()
    {
        speed = 5.0f;
        damage = 20;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
        // Debug.Log("type 1 buttlet damage");
    }

}
