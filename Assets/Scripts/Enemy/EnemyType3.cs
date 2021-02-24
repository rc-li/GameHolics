using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType3 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 150;
        value = 25;
        startSpeed = 1.0f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

    }


}
