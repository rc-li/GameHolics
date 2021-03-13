using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTowerType1 : MonoBehaviour
{
	public GameObject towerPrefab;
    public static int towerPrice = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log ("Button Clicked");
    }
    public void OnMouseUp()
	{
        PlayerStatus.towerPrefab = towerPrefab;
        PlayerStatus.selectTowerNumber = 1;
        //Debug.Log("Type 1 tower selected!!!");
	}
}
