using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1 : Enemy
{
    void Start()
    {
        maxHealth = 50;
        startSpeed = 4f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 10;
        attackPoint = 10;
    }

}
