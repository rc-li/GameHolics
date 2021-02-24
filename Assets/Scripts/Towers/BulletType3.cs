using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType3 : Bullet
{
    void Start()
    {
        speed = 4.0f;
        damage = 30;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
        // Debug.Log("type 3 buttlet damage");
    }
}
