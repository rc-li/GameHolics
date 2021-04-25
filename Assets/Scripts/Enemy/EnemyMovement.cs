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
    private Vector3 _lastPointPosition;
    private SpriteRenderer _spriteRenderer;
    public Vector3 CurrentPointPosition;

    public string pathName;
    [SerializeField] private GameObject[] paths;


    private void Awake()
    {
        paths = GameObject.FindGameObjectsWithTag("Route");
        // for (int i = 0; i < paths.Length; i++)
        // {
        //     Debug.Log(paths[i].name);

        // }
        // pathName = paths[WaveSpawner.randomSpawn].name;
        // wayPoints = GameObject.Find(pathName).GetComponent<WayPoints>();
        destination = GameObject.Find("trojan");
        enemy = GetComponent<Enemy>();
    }



    void Start()
    {
        FindWay();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        target = wayPoints.pathObjs[0];
        _lastPointPosition = transform.position;

    }

    void Update()
    {
        CurrentPointPosition = target.position;
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);
        Rotate();
        if (CurrentPointPositionReached())
        {
            GetNextWayPoint();
        }

        if (GameStatus.gameIsOver == true)
        {
            enabled = false;
        }
    }

    private void FindWay()
    {
        // paths = GameObject.FindGameObjectsWithTag("Route");
        // pathName = paths[WaveSpawner.randomSpawn].name;
        int temp = WaveSpawner.randomSpawn + 1;
        pathName = "Route" + temp;
        Debug.Log(gameObject.name + "pathName" + pathName);
        wayPoints = GameObject.Find(pathName).GetComponent<WayPoints>();
    }

    private bool CurrentPointPositionReached()
    {
        float distance = Vector2.Distance(target.position, transform.position);
        if (distance <= switchPointDistance)
        {
            _lastPointPosition = transform.position;
            return true;
        }
        return false;

    }

    private void Rotate()
    {
        if (CurrentPointPosition.x > _lastPointPosition.x)
        {
            _spriteRenderer.flipX = false;
        }
        else
        {
            _spriteRenderer.flipX = true;
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

    void ArriveDestination()
    {
        PlayerStatus.lives--; // reference to PlayerStatus, GameStatus
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);
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
