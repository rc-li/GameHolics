using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private WayPoints wayPoints;
    private Enemy enemy;
    public int wayPointIndex = 0;
    private float switchPointDistance = 0.1f;
    private GameObject destination;
    public Transform target;
    // Rigidbody2D rbody;


    public string pathName;
    public GameObject[] paths;


    private void Awake()
    {
        pathName = paths[WaveSpawner.randomSpawn].name;
        wayPoints = GameObject.Find(pathName).GetComponent<WayPoints>();
        destination = GameObject.Find("trojan");
        // rbody = GetComponent<Rigidbody2D>();
        enemy = GetComponent<Enemy>();
    }

    void Start()
    {
        target = wayPoints.pathObjs[0];
    }

    void Update()
    {
        float distance = Vector2.Distance(target.position, transform.position);
        // transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * enemy.speed);
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);
        // Vector2 nextPosition = new Vector2(target.position.x, target.position.y);
        // Vector2 currentPosition = rbody.position;
        // Vector2 direction = nextPosition - currentPosition;
        // direction = Vector2.ClampMagnitude(direction, 1);
        // Vector2 velocity = direction * enemy.speed;
        // rbody.MovePosition(currentPosition + velocity * Time.fixedDeltaTime);


        // rotation
        // Vector2 direction = nextPosition - transform.position;
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(angle, Vector2.forward);

        if (distance <= switchPointDistance)
        {
            GetNextWayPoint();
        }

        if (GameStatus.gameIsOver == true)
        {
            enabled = false;
        }
    }

    void GetNextWayPoint()
    {
        if (wayPointIndex < wayPoints.pathObjs.Count - 1)
        {
            wayPointIndex++;
            target = wayPoints.pathObjs[wayPointIndex];
            return;
        }

        if (wayPointIndex == wayPoints.pathObjs.Count - 1)
        {
            wayPointIndex++;
            target = destination.transform;
            return;
        }
        ArriveDestination();
    }

    // void GetPreviousWaypoint()
    // {
    //     if (wayPointIndex > 0)
    //     {
    //         wayPointIndex--;
    //         target = wayPoints.pathObjs[wayPointIndex];
    //         return;
    //     }

    //     if (wayPointIndex == 0)
    //     {
    //         BackToDeparture();
    //         return;
    //     }
    // }

    // void BackToDeparture()
    // {
    //     WaveSpawner.aliveEnemyNumber--;
    //     Destroy(gameObject);
    // }

    void ArriveDestination()
    {
        PlayerStatus.lives--; // reference to PlayerStatus, GameStatus
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);
        // Debug.Log("arrived destination");
    }
}



/* --- old version --- */

// {
//     private Enemy enemy;
//     private Transform target;
//     private int wayPointIndex = 0;

//     void Start()
//     {
//         enemy = GetComponent<Enemy>();
//         target = WayPoints.wayPoints[0];
//     }

//     void Update()
//     {
//         Vector2 direction = target.position - transform.position;
//         transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);
//         // test only: transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

//         if (Vector2.Distance(transform.position, target.position) <= 0.1f)
//         {
//             GetNextWayPoint();
//         }

//         if (GameStatus.gameIsOver == true)
//         {
//             enabled = false;
//         }
//     }

//     void GetNextWayPoint()
//     {
//         if (wayPointIndex >= WayPoints.wayPoints.Length - 1)
//         {
//             ArriveDestination();
//             return;
//         }

//         wayPointIndex++;
//         target = WayPoints.wayPoints[wayPointIndex];
//     }

//     void ArriveDestination()
//     {
//         PlayerStatus.lives--; // reference to PlayerStatus, GameStatus
//         WaveSpawner.aliveEnemyNumber--;
//         Destroy(gameObject);
//     }
// }
