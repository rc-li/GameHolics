using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSceneShopItem : MonoBehaviour
{
    //价格
    public Text text;
    public Image image;
    public Button button;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        if(SelectedCharacters.selectedCharacters[id] == null)
        {
            text.enabled = false;
            image.enabled = false;
            button.enabled = false;
            return;
        }
        //id = SelectedCharacters.reachedIndex++;
        text.text = "$" + Cards.cardProperties[SelectedCharacters.selectedCharacters[id]].cost;
        string[] all = SelectedCharacters.selectedCharacters;

        //之后要改
        image.sprite = Resources.Load("UI/" + Cards.all[SelectedCharacters.selectedCharacters[id]], typeof(Sprite)) as Sprite;

        button.onClick.AddListener(delegate { OnClick(); });
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void OnClick()
    {
        //PlayerStatus.
        PlayerStatus.selectTowerNumber = id;

        //IO操作非常expensive，应该在游戏加载之前就把所有的动态perfab全部
        //加载到内存中，然后动态进行access而不应该是runtime IO interruption
        //之后有空再重写一下
        PlayerStatus.towerPrefab = Resources.Load("prefabs/" + Cards.all[SelectedCharacters.selectedCharacters[id]]) as GameObject;

        Hover hover = GameObject.Find("Hover").GetComponent<Hover>();
        hover.Activate(image.sprite);
    }

}
