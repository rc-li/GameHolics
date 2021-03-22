using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public Color rayColor = Color.white;
    public List<Transform> pathObjs = new List<Transform>();
    public Transform[] wayPoints;

    // private void Awake()
    // {

    private void OnDrawGizmos()
    {

        Gizmos.color = rayColor;
        wayPoints = GetComponentsInChildren<Transform>();
        pathObjs.Clear();

        foreach (Transform wayPoint in wayPoints)
        {
            if (wayPoint != this.transform)
            {
                pathObjs.Add(wayPoint);
            }
        }

        for (int i = 0; i < pathObjs.Count; i++)
        {
            Vector3 currentPoint = pathObjs[i].position;
            Gizmos.DrawWireSphere(currentPoint, 0.3f);


            if (i > 0)
            {
                Vector3 prePoint = pathObjs[i - 1].position;
                Gizmos.DrawLine(prePoint, currentPoint);
            }
        }
    }
}

//    public static Transform[] pathObjs;
//     void Awake()
//     {
//         pathObjs = new Transform[transform.childCount];
//         for (int i = 0; i < pathObjs.Length; i++)
//         {
//             pathObjs[i] = transform.GetChild(i);
//         }
//     }




