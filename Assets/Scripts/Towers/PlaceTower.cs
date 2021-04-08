using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{

    // public GameObject towerPrefab;
    private GameObject tower;
    private AudioSource audioSource;
    public AudioClip noMoney;
    private Hover hover;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool canPlaceTower()
    {

        return tower == null;
    }

    void OnMouseUp()
    {
        hover = GameObject.Find("Hover").GetComponent<Hover>();
        if (canPlaceTower())
        {
            //if (PlayerStatus.selectTowerNumber == 1 && PlayerStatus.money >= SelectTowerType1.towerPrice)
            //{
            //    tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //    PlayerStatus.money -= SelectTowerType1.towerPrice;
            //    audioSource.PlayOneShot(audioSource.clip);
            //}
            //else if (PlayerStatus.selectTowerNumber == 2 && PlayerStatus.money >= SelectTowerType2.towerPrice)
            //{
            //    tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //    PlayerStatus.money -= SelectTowerType2.towerPrice;
            //    audioSource.PlayOneShot(audioSource.clip);
            //}
            //else if (PlayerStatus.selectTowerNumber == 3 && PlayerStatus.money >= SelectTowerType3.towerPrice)
            //{
            //    tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //    PlayerStatus.money -= SelectTowerType3.towerPrice;
            //    audioSource.PlayOneShot(audioSource.clip);
            //}
            //else if (PlayerStatus.selectTowerNumber == 4 && PlayerStatus.money >= SelectTowerType3.towerPrice)
            //{
            //    tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //    PlayerStatus.money -= SelectTowerType4.towerPrice;
            //    audioSource.PlayOneShot(audioSource.clip);
            //}
            //else if (PlayerStatus.selectTowerNumber == 5 && PlayerStatus.money >= SelectTowerType3.towerPrice)
            //{
            //    tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //    PlayerStatus.money -= SelectTowerType5.towerPrice;
            //    audioSource.PlayOneShot(audioSource.clip);
            //}

            //游戏数值设置之后再用一个config file来做
            //现在测试暂时先这么写
            if (PlayerStatus.money > 0)
            {
                tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
                PlayerStatus.money -= 1;
                audioSource.PlayOneShot(audioSource.clip);
            }
            else
            {
                if (PlayerStatus.selectTowerNumber != 0)
                {
                    audioSource.PlayOneShot(noMoney);
                }

            }


            hover.Deactivate();
            //tower = (GameObject) Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //Debug.Log(tower.GetComponent<Tower>().GetPrice());
            //PlayerStatus.money -= tower.GetComponent<Tower>().GetPrice();
            //AudioSource audioSource = gameObject.GetComponent<AudioSource>();

        }
    }
}
