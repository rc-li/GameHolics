using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCollision : MonoBehaviour
{
    private TowerType6 tower;
    private Enemy enemy;
    private string enemyTag = "Enemy";

    private void Start()
    {
        tower = GetComponent<TowerType6>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == enemyTag)
        {
            enemy = collision.GetComponentInParent<Enemy>();
            tower.TowerTakeDamage(enemy.attackPoint);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        tower = null;
        enemy = null;
    }
}
