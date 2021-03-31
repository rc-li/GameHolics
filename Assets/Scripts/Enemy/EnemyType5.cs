using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType5 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 600;
        startSpeed = 2f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 25;
        attackPoint = 50;
    }
}
