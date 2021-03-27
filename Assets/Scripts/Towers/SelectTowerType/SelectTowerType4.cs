using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectTowerType4 : MonoBehaviour
{
    public GameObject towerPrefab;
    public static int towerPrice;
    private Sprite sprite;
    private Hover hover;
    private Image image;

    void Start()
    {
        towerPrice = TowerType4.price;
    }

    public void OnMouseUp()
    {
        PlayerStatus.towerPrefab = towerPrefab;
        PlayerStatus.selectTowerNumber = 4;
        sprite = gameObject.GetComponent<Image>().sprite;
        hover = GameObject.Find("Hover").GetComponent<Hover>();
        //Debug.Log(sprite);
        hover.Activate(sprite);
        // Debug.Log("Type 4 tower selected!!!");
    }
}
