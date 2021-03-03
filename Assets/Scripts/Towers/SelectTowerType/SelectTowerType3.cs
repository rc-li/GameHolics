using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTowerType3 : MonoBehaviour
{
	public GameObject towerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
	{
        PlayerStatus.towerPrefab = towerPrefab;
        // Debug.Log("Type 3 tower selected!!!");
	}
}
