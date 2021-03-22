using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected GameObject target;
    protected Transform startPoint;

    protected float speed;
    protected int damage;
    protected float slowPercent;

    private void Start()
    {
        startPoint = transform;
    }
    public void LocateTarget(GameObject _target)
    {
        target = _target;
    }

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 direction = target.transform.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        // to make sure we can touch the target in this frame
        // direction.magnitude -> the length of direction vector
        // if (direction.magnitude <= distanceThisFrame)
        if (Vector2.Distance(gameObject.transform.position, target.transform.position) <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
        // gameObject.GetComponent<Rigidbody2D>().rotation = angle;
    }

    protected virtual void HitTarget()
    {
        Destroy(gameObject);
    }
}
