﻿using System;
using System.Collections.Generic;

//C#的instance中不能用singleton，凑合一下吧
public static class GlobalPlayer
{
    private static int id;
    private static string name;
    public static int hp = 1000;
    public static int money = 1000;
    public static HashSet<string> cards = new HashSet<string>();

    //public Player(string name)
    //{
    //    id = 0;
    //    hp = 1000;
    //    money = 1000;
    //    this.name = name;
    //}
}
