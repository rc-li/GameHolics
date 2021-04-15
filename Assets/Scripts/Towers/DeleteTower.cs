using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTower : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject tower = this.transform.parent.gameObject;
        Destroy(tower);
    }
}
