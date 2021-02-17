using System.Collections;
using System.Collections.Generic;
using Bolt;
using UnityEngine;

public class NetworkCallbacks : GlobalEventListener
{
    public GameObject cube;

    // Start is called before the first frame update
    public override void SceneLoadLocalDone(string scene)
    {
        //base.SceneLoadLocalDone(scene);
        BoltNetwork.Instantiate(cube, new Vector3(Random.Range(-4,4), 0,
            Random.Range(-4, 4)), Quaternion.identity);
    }
}
