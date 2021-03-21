// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GetPath : MonoBehaviour
// {
//     public GameObject[] paths;
//     public static int randomPath;

//     private void Awake()
//     {
//         // int Random.Range Return a random int within [minInclusive..maxExclusive) (Read Only)
//         randomPath = Random.Range(0, paths.Length);
//         // transform.position = paths[randomPath].transform.position;
//         MovementOnPath path = GetComponent<MovementOnPath>();
//         path.pathName = paths[randomPath].name;
//     }
// }
