using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType2 : Enemy
{
    void Start()
    {
        maxHealth = 100;
        startSpeed = 4.0f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 20;
        attackPoint = 10;
    }

}

