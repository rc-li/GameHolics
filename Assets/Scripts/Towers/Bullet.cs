using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected Transform target;

    protected float speed;
    protected int damage;
    protected float slowPercent;

    public void LocateTarget (Transform _target) {
        target = _target;
    }

    private void Update() {
        if (target == null) {
            Destroy(gameObject);
            return;
        }

        Vector2 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        // to make sure we can touch the target in this frame
        // direction.magnitude -> the length of direction vector
        if ( direction.magnitude <= distanceThisFrame) {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
    }

    protected virtual void HitTarget() {
        Destroy(gameObject);
    }
}
