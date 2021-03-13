using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{

	// public GameObject towerPrefab;
    private GameObject tower;
    private AudioSource audioSource;
    public AudioClip noMoney;
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
        if (canPlaceTower())
        {
            if (PlayerStatus.selectTowerNumber == 1 && PlayerStatus.money >= SelectTowerType1.towerPrice)
            {
                tower = (GameObject) Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
                PlayerStatus.money -= SelectTowerType1.towerPrice;
                audioSource.PlayOneShot(audioSource.clip);
            }
            else if (PlayerStatus.selectTowerNumber == 2 && PlayerStatus.money >= SelectTowerType2.towerPrice)
            {
                tower = (GameObject) Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
                PlayerStatus.money -= SelectTowerType2.towerPrice;
                audioSource.PlayOneShot(audioSource.clip);
            }
            else if (PlayerStatus.selectTowerNumber == 3 && PlayerStatus.money >= SelectTowerType3.towerPrice)
            {
                tower = (GameObject) Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
                PlayerStatus.money -= SelectTowerType3.towerPrice;
                audioSource.PlayOneShot(audioSource.clip);
            }
            else
            {
                audioSource.PlayOneShot(noMoney);
            }
            //tower = (GameObject) Instantiate(PlayerStatus.towerPrefab, transform.position, Quaternion.identity);
            //Debug.Log(tower.GetComponent<Tower>().GetPrice());
            //PlayerStatus.money -= tower.GetComponent<Tower>().GetPrice();
            //AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            
        }
	}
}
