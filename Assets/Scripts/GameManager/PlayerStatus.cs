using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    public static int lives;
    public int startLives = 20;

    public static int money;
    public int startMoney = 100;

    public static int Rounds;

    public static GameObject towerPrefab;
    public static int selectTowerNumber;

    void Start()
    {
        lives = startLives;
        money = startMoney;
        Rounds = 0;
        towerPrefab = null;
    }

    private void Update()
    {
        if (lives < 0)
        {
            lives = 0;
        }
    }
}
