using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTowerType3 : MonoBehaviour
{
	public GameObject towerPrefab;
    public static int towerPrice = 110;
    private Sprite sprite;
    private Hover hover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseUp()
	{
        PlayerStatus.towerPrefab = towerPrefab;
        PlayerStatus.selectTowerNumber = 3;
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        hover = GameObject.Find("Hover").GetComponent<Hover>();
        //Debug.Log(sprite);
        hover.Activate(sprite);
        // Debug.Log("Type 3 tower selected!!!");
	}
}
