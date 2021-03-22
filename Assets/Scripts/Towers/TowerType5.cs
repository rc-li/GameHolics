using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type5: non-bullet explosion tower

public class TowerType5 : Tower
{
    private int explosionTowerDamage = 500;
    public void Start()
    {
        range = 3.0f;
        fireRate = 0.5f;
        InvokeRepeating("UpdateTarget", 0.0f, 2.0f); // invoke UpdateTarget() every 0.5 seconds starts from 0 second
    }

    protected override void Shoot()
    {
        Debug.Log("enemies list: " + targetEnemies.Count);

        foreach (var targetEnemy in targetEnemies)
        {
            targetEnemy.GetComponent<Enemy>().TakeDamage(explosionTowerDamage);
            Debug.Log("shooted");
        }
        // // change to ananimation?
        // GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Bullet bullet = bulletInst.GetComponent<BulletType3>();

        // if (bullet != null)
        // {
        //     bullet.LocateTarget(target);
        //     // shooting audio
        //     bullet.GetComponent<AudioSource>().Play();
        // }
    }
}

