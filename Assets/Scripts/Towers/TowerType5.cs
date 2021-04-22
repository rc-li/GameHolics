using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type5: non-bullet explosion tower

public class TowerType5 : Tower
{
    private int explosionTowerDamage = 500;
    new public static int price = 150;
    public GameObject explosionEffect;

    public void Start()
    {
        range = 3.0f;
        fireRate = 0.5f;
        InvokeRepeating("UpdateTarget", 0.0f, 2.0f); // invoke UpdateTarget() every 0.5 seconds starts from 0 second
    }

    protected override void Shoot()
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);

        // Debug.Log("enemies list: " + targetEnemies.Count);
        foreach (var targetEnemy in targetEnemies)
        {
            targetEnemy.GetComponent<Enemy>().TakeDamage(explosionTowerDamage);
        }

        Destroy(gameObject);
    }
}

