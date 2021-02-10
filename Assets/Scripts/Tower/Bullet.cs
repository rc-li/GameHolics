using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int damage;
    private Rigidbody2D rb;

    private Transform targetObject;
    private Vector2 targetPosition;

    // private Vector2 screenBounds;

    void Start()
    {
        speed = 10.0f;
        damage = 20;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.0f, 0.0f); // transform.right * speed;
        targetObject = GameObject.FindGameObjectWithTag("Minion").transform;
        targetPosition = new Vector2(targetObject.position.x, targetObject.position.y);
        // screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    void Update()
    {
        // if(transform.position.x > screenBounds.x) {
        //     Destroy(gameObject);
        // }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position.x == targetPosition.x && transform.position.y == targetPosition.y) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
    
        if (hitInfo.CompareTag("Minion")) {
            Destroy(this.gameObject);
            hitInfo.GetComponent<MinionHealth>().TakeDamage(damage);
        }
    }
}
