using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType4 : Enemy
{
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
