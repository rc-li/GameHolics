﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CardHoler : MonoBehaviour
{
    public int index;
    public Image image;
    public bool status = false;
    public GameObject self;
    public GameObject check;
    public Button button;
    private int selectedIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        
        check.SetActive(false);
        button.onClick.AddListener(delegate { OnClick(); });
        //onClick.AddListener(delegate { OnClick(); });
        if (index >= GlobalPlayer.cards.Count)
            self.SetActive(false);
        else image.sprite = Resources.Load("UI/" + GlobalPlayer.cards[index], typeof(Sprite)) as Sprite;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    void OnClick()
    {
        status = status ^ true;
        check.SetActive(status);
        if (!status)
        {
            //SelectedCharacters.images[selectedIndex].SetActive(false);
            SelectedCharacters.images[selectedIndex].sprite = null;
            SelectedCharacters.images[selectedIndex].enabled = false;
            SelectedCharacters.selectedCharacters[selectedIndex] = null;
            selectedIndex = -1;
            
        }
        else
        {
            selectedIndex = SelectedCharacters.addACardToSelectedSet(GlobalPlayer.cards[index]);
            if (selectedIndex != -1)
            {
                SelectedCharacters.images[selectedIndex].sprite = Resources.Load("UI/" + GlobalPlayer.cards[index], typeof(Sprite)) as Sprite;
                SelectedCharacters.images[selectedIndex].enabled = true;
                // = Resources.Load(GlobalPlayer.cards[index],typeof(sprite)) as Sprite;
                //SelectedCharacters.addACardToSelectedSet();
            }
        }
    }
}
