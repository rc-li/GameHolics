using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type3: fireball damage tower

public class TowerType3 : Tower
{
    public override void Start()
    {
        base.Start();
        range = Cards.cardProperties["TowerType3"].range;
        fireRate = Cards.cardProperties["TowerType3"].fireRate;
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f);
    }

    protected override void Shoot()
    {
        GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInst.GetComponent<BulletType3>();

        if (bullet != null)
        {
            bullet.LocateTarget(target);

            // shooting audio
            bullet.GetComponent<AudioSource>().Play();
        }
    }



}
