using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private WayPoints wayPoints;
    private Enemy enemy;
    private int wayPointIndex = 0;
    private float distanceToNext = 0.1f;
    private GameObject destination;
    public string pathName;
    public GameObject[] paths;

    Vector3 currentPosition;
    Vector3 nextPosition;

    void Start()
    {
        pathName = paths[WaveSpawner.randomSpawn].name;
        wayPoints = GameObject.Find(pathName).GetComponent<WayPoints>();
        enemy = GetComponent<Enemy>();
        currentPosition = transform.position;
        nextPosition = wayPoints.pathObjs[wayPointIndex].position;
    }

    void Update()
    {
        float distance = Vector3.Distance(nextPosition, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, Time.deltaTime * enemy.speed);

        // rotation
        // Vector3 direction = nextPosition - transform.position;
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (distance <= distanceToNext)
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
            nextPosition = wayPoints.pathObjs[wayPointIndex].position;
            return;
        }

        if (wayPointIndex == wayPoints.pathObjs.Count - 1)
        {
            destination = GameObject.Find("trojan");
            wayPointIndex++;
            nextPosition = destination.transform.position;
            return;
        }

        if (transform.position == nextPosition)
        {
            ArriveDestination();
        }
    }

    void ArriveDestination()
    {
        PlayerStatus.lives--; // reference to PlayerStatus, GameStatus
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);
        // Debug.Log("arrived destination");
    }
}




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
