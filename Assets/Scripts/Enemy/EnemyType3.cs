using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType3 : Enemy
{
    public static Action<GameObject> OnEnemyKilled;
    void Start()
    {
        maxHealth = 200;
        startSpeed = 2.0f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 12;
        attackPoint = 10;
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
