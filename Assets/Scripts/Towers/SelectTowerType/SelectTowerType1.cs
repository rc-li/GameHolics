using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTowerType1 : MonoBehaviour
{
    public GameObject towerPrefab;
    public static int towerPrice;
    private Sprite sprite;
    private Hover hover;
    private Image image;

    void Start()
    {
        towerPrice = TowerType1.price;
        //hover = GameObject.Find("Hover").GetComponent<Hover>();
        //sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    public void Click()
    {
        Debug.Log("Button Clicked");

    }
    public void OnMouseUp()
    {
        PlayerStatus.towerPrefab = towerPrefab;
        PlayerStatus.selectTowerNumber = 1;
        sprite = gameObject.GetComponent<Image>().sprite;
        hover = GameObject.Find("Hover").GetComponent<Hover>();
        //Debug.Log(sprite);
        hover.Activate(sprite);
        //Debug.Log("Type 1 tower selected!!!");
    }
}
