using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    private Enemy enemy;
    private Transform target;
    private int wayPointIndex = 0;

    void Start()
    {
        enemy = GetComponent<Enemy>();
        target = WayPoints.wayPoints[0];
    }

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World);
        // test only: transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wayPointIndex >= WayPoints.wayPoints.Length - 1)
        {
            ArriveDestination();
            return;
        }

        wayPointIndex++;
        target = WayPoints.wayPoints[wayPointIndex];
    }

    void ArriveDestination()
    {
        PlayerStatus.lives--; // reference to PlayerStatus, GameStatus
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);
    }
}
