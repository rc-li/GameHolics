using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBack : MonoBehaviour
{
    private WayPoints wayPoints;
    private Enemy enemy;
    private int wayPointIndex = 0;
    private float switchPointDistance = 0.1f;
    private GameObject destination;
    private Transform target;

    public string pathName;
    public GameObject[] paths;


    private void Awake()
    {
        pathName = paths[WaveSpawner.randomSpawn].name;
        wayPoints = GameObject.Find(pathName).GetComponent<WayPoints>();
        destination = GameObject.Find("trojan");
    }

    void Start()
    {
        this.enabled = false;
        enemy = GetComponent<Enemy>();
        target = wayPoints.pathObjs[0];
    }

    void Update()
    {
        float distance = Vector2.Distance(target.position, transform.position);
        // transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * enemy.speed);
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);

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

