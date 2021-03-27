using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectTowerType5 : MonoBehaviour
{
    public GameObject towerPrefab;
    public static int towerPrice;
    private Sprite sprite;
    private Hover hover;
    private Image image;

    void Start()
    {
        towerPrice = TowerType5.price;
    }


    public void OnMouseUp()
    {
        PlayerStatus.towerPrefab = towerPrefab;
        PlayerStatus.selectTowerNumber = 5;
        sprite = gameObject.GetComponent<Image>().sprite;
        hover = GameObject.Find("Hover").GetComponent<Hover>();
        //Debug.Log(sprite);
        hover.Activate(sprite);
        // Debug.Log("Type 5 tower selected!!!");
    }
}
