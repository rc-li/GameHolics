using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type6: defense potato tower

public class TowerType6 : Tower
{

    public HealthBar healthbar;
    private int maxHealth;
    private int currentHealth;

    public void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    public void TowerTakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetCurrentHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);

        // new type - audio update required
        // death audio
        // AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        // AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
    }
}

