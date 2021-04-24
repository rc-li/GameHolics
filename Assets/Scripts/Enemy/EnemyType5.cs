using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType5 : Enemy
{
    public static Action<GameObject> OnEnemyKilled;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 700;
        startSpeed = 2f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 25;
        attackPoint = 50;
    }

    public override void Die()
    {
        isDead = true;
        StopMovement();
        OnEnemyKilled?.Invoke(gameObject);
        PlayerStatus.money += value;
        WaveSpawner.aliveEnemyNumber--;

        // death audio
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
    }
}
