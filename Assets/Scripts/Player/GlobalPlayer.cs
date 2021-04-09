using System;
using System.Collections;
using System.Collections.Generic;

//C#的instance中不能用singleton，凑合一下吧
public static class GlobalPlayer
{
    private static int id;
    private static string name;
    public static int hp = 1000;
    public static int money = 1000;

    //这个指改玩家从卡池中抽到的卡
    public static List<string> cards = new List<string>()
    {
        "TowerType1","TowerType2","TowerType3","TowerType4","TowerType5","TowerType6"
    };

    //public Player(string name)
    //{
    //    id = 0;
    //    hp = 1000;
    //    money = 1000;
    //    this.name = name;
    //}
}
