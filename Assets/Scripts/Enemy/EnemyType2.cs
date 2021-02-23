using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType2 : Enemy
{
    void Start()
    {
        maxHealth = 100;
        value = 20;
        startSpeed = 2.0f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        // Debug.Log("type2 enemy start function");
    }

}

