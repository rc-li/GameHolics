using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBack : MonoBehaviour
{
    private WayPoints wayPoints;
    private Enemy enemy;
    private int wayPointIndex;
    private float switchPointDistance = 0.1f;
    private GameObject destination;
    private Transform target;

    public string pathName;
    [SerializeField] private GameObject[] paths;


    private void Awake()
    {
        paths = GameObject.FindGameObjectsWithTag("Route");
        pathName = paths[WaveSpawner.randomSpawn].name;
        wayPoints = GameObject.Find(pathName).GetComponent<WayPoints>();
        destination = GameObject.Find("trojan");
        this.enabled = false;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
        wayPointIndex = gameObject.GetComponent<Enemy>().wayPointIndex - 1;
        target = wayPoints.pathObjs[wayPointIndex];
    }

    void Update()
    {
        float distance = Vector2.Distance(target.position, transform.position);
        // transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * enemy.speed);
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);
        Debug.Log("wayPointIndex: " + wayPointIndex);
        if (distance <= switchPointDistance)
        {
            GetPreviousWaypoint();
        }

        if (GameStatus.gameIsOver == true)
        {
            enabled = false;
        }
    }


    void GetPreviousWaypoint()
    {
        if (wayPointIndex > 0)
        {
            wayPointIndex--;
            target = wayPoints.pathObjs[wayPointIndex];
            return;
        }

        if (wayPointIndex == 0)
        {
            BackToDeparture();
            return;
        }
    }

    void BackToDeparture()
    {
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);
    }
}

