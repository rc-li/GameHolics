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
        id = SelectedCharacters.reachedIndex++;
        text.text = id.ToString();
        string[] all = SelectedCharacters.selectedCharacters;

        //之后要改
        image.sprite = Resources.Load(SelectedCharacters.selectedCharacters[id], typeof(Sprite)) as Sprite;

        button.onClick.AddListener(delegate { OnClick(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        //PlayerStatus.
        PlayerStatus.selectTowerNumber = id;
        PlayerStatus.towerPrefab = Resources.Load("/Prefabs/Tower/" + SelectedCharacters.selectedCharacters[id], typeof(GameObject)) as GameObject;
        Hover hover = GameObject.Find("Hover").GetComponent<Hover>();
        hover.Activate(image.sprite);
    }

}
