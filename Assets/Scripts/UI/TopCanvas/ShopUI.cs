using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopUI : MonoBehaviour
{
    private Text[] shopTexts;
    private Text shop1Text;
    private Text shop2Text;
    private Text shop3Text;
    private Text shop4Text;
    private Text shop5Text;


    private void Awake()
    {
        shopTexts = gameObject.GetComponentsInChildren<Text>();
        //shopTexts = gameObject.GetComponentInChildren<>
        foreach (var text in shopTexts)
        {
            if (text.name == "Shop1Text")
            {
                shop1Text = text;
            }

            else if (text.name == "Shop2Text")
            {
                shop2Text = text;
            }

            else if (text.name == "Shop3Text")
            {
                shop3Text = text;
            }

            else if (text.name == "Shop4Text")
            {
                shop4Text = text;
            }

            else if (text.name == "Shop5Text")
            {
                shop5Text = text;
            }
        }
    }

    private void Start()
    {
        shop1Text.text = "$ " + TowerType1.price;
        shop2Text.text = "$ " + TowerType2.price;
        shop3Text.text = "$ " + TowerType3.price;
        shop4Text.text = "$ " + TowerType4.price;
        shop5Text.text = "$ " + TowerType5.price;
    }
}
