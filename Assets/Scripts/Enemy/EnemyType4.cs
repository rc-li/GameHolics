using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType4 : Enemy
{
    void Start()
    {
        maxHealth = 600;
        value = 25;
        startSpeed = 3f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);


    }
}
