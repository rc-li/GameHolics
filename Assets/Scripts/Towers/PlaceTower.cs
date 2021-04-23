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

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private bool CanPlaceTower()
    {
        if (PlayerStatus.money > Cards.cardProperties[SelectedCharacters.selectedCharacters[PlayerStatus.selectTowerNumber]].cost)
        {
            return true;
        }
        return false;
    }

    void OnMouseUp()
    {
        hover = GameObject.Find("Hover").GetComponent<Hover>();

        if (CanPlaceTower())
        {
            // if (PlayerStatus.selectTowerNumber == 1 && PlayerStatus.money >= SelectTowerType1.towerPrice)
            // {
            //     tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //     PlayerStatus.money -= SelectTowerType1.towerPrice;
            //     audioSource.PlayOneShot(audioSource.clip);
            // }
            // else if (PlayerStatus.selectTowerNumber == 2 && PlayerStatus.money >= SelectTowerType2.towerPrice)
            // {
            //     tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //     PlayerStatus.money -= SelectTowerType2.towerPrice;
            //     audioSource.PlayOneShot(audioSource.clip);
            // }
            //}

            tower = (GameObject)Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            PlayerStatus.money -= Cards.cardProperties[SelectedCharacters.selectedCharacters[PlayerStatus.selectTowerNumber]].cost;
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
