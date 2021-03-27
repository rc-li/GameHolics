using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type4: bewitching tower
public class TowerType4 : Tower
{
    new public static int price = 100;
    public void Start()
    {
        range = 3.0f;
        fireRate = 0.5f;  // speed = 1/0.5f
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f); // invoke UpdateTarget() every 0.5 seconds starts from 0 second
    }

    protected override void Shoot()
    {
        GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInst.GetComponent<BulletType4>();

        if (bullet != null)
        {
            bullet.LocateTarget(target);
            // shooting audio
            bullet.GetComponent<AudioSource>().Play();
        }
    }
}
