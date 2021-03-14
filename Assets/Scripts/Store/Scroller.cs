using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    private float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( speed * Time.deltaTime,0f, 0f);
        if (transform.position.x <= -1000)
            //这个地方两个object之间的缝隙总是看的见，不知道应该用999还是100
            transform.SetPositionAndRotation(new Vector3(999f, 0f, 202f),
                transform.rotation);
            
    }
}
