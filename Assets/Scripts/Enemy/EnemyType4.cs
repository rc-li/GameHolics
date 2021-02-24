using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType4 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 120;
        value = 25;
        startSpeed = 1.2f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

      
    }
}
