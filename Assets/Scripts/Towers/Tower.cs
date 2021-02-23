using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected Transform target;
    protected string enemyTag = "Enemy";
    // private Enemy targetEnemy;

    protected float range; // tower shooting range
    protected float fireRate; // bullet number shooted per second
    protected float fireCountdown = 0.0f; // timer

    [Header("Setup")]
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (target == null)
        {
            return;
        }

        if (fireCountdown <= 0.0f)
        {
            Shoot();
            fireCountdown = 1.0f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    // locate enemy
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance < range)
        {
            target = nearestEnemy.transform;
            // targetEnemy = nearestEnemy.GetComponent<Enemy>();

        }
        else
        {
            target = null;
        }
    }

    protected virtual void Shoot()
    {
        // "object casting": create a temporary gameObject for Instantiate object
        GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInst.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.LocateTarget(target);
        }
    }



    // doesn't work right now - to be fixed
    // show tower shooting range | red line | will disappear when un-select the tower gameObject
    protected void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

}

