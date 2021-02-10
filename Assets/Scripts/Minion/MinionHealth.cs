using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public float speed;
    public HealthBar healthbar;

    // public float stoppingDistance;
    // public float retreatDistance;
    // public Transform player;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

        // if (Vector2.Distance(transform.position, player.position) > stoppingDistance) {
        //     transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        // } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance) {
        //     transform.position = this.transform.position;
        // } else if (Vector2.Distance(transform.position, player.position) < retreatDistance) {
        //     transform.position = Vector2.MoveTowards(transform.position, player.position, - speed * Time.deltaTime);

        // }

        // if(Input.GetKeyDown(KeyCode.Space)){
        //     TakeDamage(10);
        // }
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthbar.SetCurrentHealth(currentHealth);

        if (currentHealth <= 0) {
            Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
