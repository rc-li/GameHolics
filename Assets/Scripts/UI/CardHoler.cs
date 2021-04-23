using System.Collections;
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

    void Start()
    {
        check.SetActive(false);
        button.onClick.AddListener(delegate { OnClick(); });
        //onClick.AddListener(delegate { OnClick(); });
        if (index >= GlobalPlayer.cards.Count)
            self.SetActive(false);
        else
            image.sprite = Resources.Load("UI/" + Cards.all[GlobalPlayer.cards.ElementAt(index)], typeof(Sprite)) as Sprite;
    }

    void OnClick()
    {
        status = status ^ true;
        check.SetActive(status);

        //该角色被移除
        if (!status)
        {
            //SelectedCharacters.images[selectedIndex].SetActive(false);
            SelectedCharacters.images[selectedIndex].sprite = null;
            SelectedCharacters.images[selectedIndex].enabled = false;
            SelectedCharacters.texts[selectedIndex].enabled = false;
            SelectedCharacters.selectedCharacters[selectedIndex] = null;
            selectedIndex = -1;

        }
        else//该角色被选入出战编队
        {   //传的永远都是角色的名字，它的prefab/property什么都通过这个名字在Cards里面去查询
            selectedIndex = SelectedCharacters.addACardToSelectedSet(GlobalPlayer.cards.ElementAt(index));
            if (selectedIndex != -1)
            {
                SelectedCharacters.texts[selectedIndex].text = "$" + Cards.cardProperties[GlobalPlayer.cards.ElementAt(index)].cost;
                // SelectedCharacters.images[selectedIndex].sprite = Resources.Load("UI/" + Cards.all[GlobalPlayer.cards.ElementAt(index)], typeof(Sprite)) as Sprite;
                SelectedCharacters.images[selectedIndex].sprite = Resources.Load("UI/" + Cards.cardProperties[GlobalPlayer.cards.ElementAt(index)].name, typeof(Sprite)) as Sprite;
                SelectedCharacters.images[selectedIndex].enabled = true;
                SelectedCharacters.texts[selectedIndex].enabled = true;
                // = Resources.Load(GlobalPlayer.cards[index],typeof(sprite)) as Sprite;
                //SelectedCharacters.addACardToSelectedSet();
            }
        }
    }
}
