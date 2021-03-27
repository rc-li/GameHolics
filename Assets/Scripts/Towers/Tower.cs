using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected int price = 0;
    protected float range; // tower shooting range
    protected float fireRate; // bullet number shooted per second
    protected float fireCountdown = 0.0f; // timer
    protected GameObject target;
    protected List<GameObject> targetEnemies = new List<GameObject>();
    protected string enemyTag = "Enemy";


    [Header("Setup")]
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (GameStatus.gameIsOver == true)
        {
            enabled = false;
        }

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
        targetEnemies.Clear();
        float shortestDistance = Mathf.Infinity;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }

            if (distanceToEnemy <= range)
            {
                targetEnemies.Add(enemy);
            }

            if (distanceToEnemy > range)
            {
                targetEnemies.Remove(enemy);
            }
        }

        if (nearestEnemy != null && shortestDistance < range)
        {
            target = nearestEnemy;
        }
        else
        {
            target = null;
        }
    }

    // void UpdateTargets()
    // {
    //     targetEnemies.Clear();
    //     GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
    //     foreach (GameObject enemy in enemies)
    //     {
    //         float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
    //         if (distanceToEnemy <= range)
    //         {
    //             targetEnemies.Add(enemy);
    //         }

    //         if (distanceToEnemy > range)
    //         {
    //             targetEnemies.Remove(enemy);
    //         }
    //     }
    //     Debug.Log("enemies list: " + targetEnemies.Count);
    // }

    protected virtual void Shoot()
    {
        // "object casting": create a temporary gameObject for Instantiate object
        // GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Bullet bullet = bulletInst.GetComponent<Bullet>();

        // if (bullet != null)
        // {
        //     bullet.LocateTarget(target);
        //     // shooting audio
        //     bullet.GetComponent<AudioSource>().Play();
        // }
    }



    // doesn't work right now - to be fixed
    // show tower shooting range | red line | will disappear when un-select the tower gameObject
    protected void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public int GetPrice()
    {
        return price;
    }

    void OnMouseDown()
    {
        GameObject deleteButton = this.transform.Find("DeleteButton").gameObject;
        if (deleteButton.activeSelf) deleteButton.SetActive(false);
        else deleteButton.SetActive(true);
    }

}

