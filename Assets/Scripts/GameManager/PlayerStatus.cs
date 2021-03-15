using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    public static int lives;
    public static int money;
    public int startLives = 20;
    public int startMoney = 100;

    void Start()
    {
        lives = startLives;
        money = startMoney;
    }
}
