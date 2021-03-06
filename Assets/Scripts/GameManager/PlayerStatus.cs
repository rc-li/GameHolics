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

    void Start()
    {
        lives = startLives;
        money = startMoney;
        Rounds = 0;
    }
}
