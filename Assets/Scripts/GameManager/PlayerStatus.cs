using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    public static int lives;
    public static int startLives = 30;

    public static int money;
    public static int startMoney = 900;

    public static int Rounds;

    public static GameObject towerPrefab;
    public static int selectTowerNumber;

    public void Start()
    {

        // lives = GlobalPlayer.hp;
        // money = GlobalPlayer.money; //startMoney;

        lives = startLives;
        money = startMoney;
        Rounds = 0;
        towerPrefab = null;
    }

    public void Update()
    {
        if (lives < 0)
        {
            lives = 0;
        }

        if (money < 0)
        {
            money = 0;
        }
    }
}
