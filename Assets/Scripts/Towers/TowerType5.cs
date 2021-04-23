using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type5: non-bullet explosion tower

public class TowerType5 : Tower
{
    private int explosionTowerDamage;
    public GameObject explosionEffect;

    public override void Start()
    {
        range = Cards.cardProperties["TowerType5"].range;
        fireRate = Cards.cardProperties["TowerType5"].fireRate;
        explosionTowerDamage = Cards.cardProperties["TowerType5"].damage;
        InvokeRepeating("UpdateTarget", 0.0f, 2.0f);
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

