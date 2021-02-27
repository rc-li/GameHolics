using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int maxHealth;
    protected int currentHealth;
    protected int value;
    protected float startSpeed;

    public float speed;
    public HealthBar healthbar;
    private bool isDead = false;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetCurrentHealth(currentHealth);

        if (currentHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    public void SlowDown(float slowPercent)
    {
        speed = startSpeed * (1f - slowPercent);
    }

    public void Die()
    {
        isDead = true;
        PlayerStatus.money += value;
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);
    }
}
