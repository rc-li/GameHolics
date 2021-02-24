using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType2 : Bullet
{
    void Start()
    {
        speed = 5.0f;
        damage = 5;
        slowPercent = 0.3f;
    }

    protected override void HitTarget()
    {
        base.HitTarget();
        target.GetComponent<Enemy>().TakeDamage(damage);
        target.GetComponent<Enemy>().SlowDown(slowPercent);
        // Debug.Log("type 2 buttlet damage");
    }
}
