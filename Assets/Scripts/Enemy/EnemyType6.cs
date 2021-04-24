using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType6 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 800;
        startSpeed = 1f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 25;
        attackPoint = 50;
    }
}
