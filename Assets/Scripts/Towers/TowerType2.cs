using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type2: iceball damage-slow down tower
public class TowerType2 : Tower
{
    public override void Start()
    {
        base.Start();
        range = Cards.cardProperties["TowerType2"].range;
        fireRate = Cards.cardProperties["TowerType2"].fireRate;
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f);
    }

    protected override void Shoot()
    {
        GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInst.GetComponent<BulletType2>();

        if (bullet != null)
        {
            bullet.LocateTarget(target);
            // shooting audio
            bullet.GetComponent<AudioSource>().Play();
        }
    }
}
