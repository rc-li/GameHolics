using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1 : Enemy
{
    void Start()
    {
        maxHealth = 50;
        value = 10;
        startSpeed = 1.5f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        // Debug.Log("type1 enemy start function");
    }

}
