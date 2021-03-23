using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameObject tower = this.transform.parent.gameObject;
        Destroy(tower);
    }
}
