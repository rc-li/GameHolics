using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionMovement : MonoBehaviour
{
     public float speed;

     private Transform target;
     private int wayPointIndex = 0;

     void Start() {
         speed = 2.0f;
         target = WayPoints.wayPoints[0];
     }

     void Update() {
         Vector2 direction = target.position - transform.position;
         transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.1f) {
            GetNextWayPoint();
        }
     }

     void GetNextWayPoint() {

         if ( wayPointIndex >= WayPoints.wayPoints.Length - 1) { 
             Destroy(gameObject);
             return;
         }
         wayPointIndex ++;
         target = WayPoints.wayPoints[wayPointIndex];
     }
}



// Rigidbody2D rigidbody2d;
    // float horizontal; 
    // float vertical;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rigidbody2d = GetComponent<Rigidbody2D>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     horizontal = Input.GetAxis("Horizontal");
    //     vertical = Input.GetAxis("Vertical");
    // }

    // void FixedUpdate()
    // {
    //     Vector2 position = rigidbody2d.position;
    //     position.x = position.x + 3.0f * horizontal * Time.deltaTime;
    //     position.y = position.y + 3.0f * vertical * Time.deltaTime;

    //     rigidbody2d.MovePosition(position);
    // }