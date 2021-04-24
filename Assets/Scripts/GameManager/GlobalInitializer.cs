// Initialization: read all property values from .csv file
// And save to dictionaries - dictionaries are initialized in Cards.cs

using System;
using System.IO;
using UnityEngine;

public static class GlobalInitializer
{
    private static string CARD_CONFIGURATION = "Cards";
    private static string PREFAB_PREFIX = "";

    //从卡牌配置文档之中读取卡牌信息
    public static void readCardConfiguration()
    {
        var resource = Resources.Load<TextAsset>(CARD_CONFIGURATION);
        //Debug.Log("read");
        //File.ReadAllLines(System.Environment.CurrentDirectory
        //+ CARD_CONFIGURATION);
        var lines = resource.text.Split('\n');
        foreach (var line in lines)
        {
            string[] strs = line.Split(',');
            if (!Cards.all.ContainsKey(strs[0]))
            {
                Cards.all.Add(strs[0], strs[1]);
                CardProperty cardProperty = new CardProperty();
                // cardProperty.name = strs[0];
                cardProperty.name = strs[1];
                cardProperty.range = float.Parse(strs[3]);
                cardProperty.fireRate = float.Parse(strs[4]);
                cardProperty.speed = float.Parse(strs[5]);
                cardProperty.slowPercent = float.Parse(strs[6]);
                cardProperty.damage = int.Parse(strs[7]);
                cardProperty.cost = int.Parse(strs[8]);
                Cards.cardProperties.Add(strs[1], cardProperty);
            }
            switch (strs[2])
            // {
            //     case "SSR":
            //         if (!Cards.SSR.ContainsKey(strs[0]))
            //             Cards.SSR.Add(strs[0], strs[1]);
            //         break;
            //     case "SR":
            //         if (!Cards.SR.ContainsKey(strs[0]))
            //             Cards.SR.Add(strs[0], strs[1]);
            //         break;
            //     case "R":
            //         if (!Cards.R.ContainsKey(strs[0]))
            //             Cards.R.Add(strs[0], strs[1]);
            //         break;
            //     case "N":
            //         if (!Cards.N.ContainsKey(strs[0]))
            //             Cards.N.Add(strs[0], strs[1]);
            //         break;
            //     default:

            //         Console.WriteLine("Error! Unknown Card Type!");
            //         break;
            // }
            {
                case "SSR":
                    if (!Cards.SSR.ContainsKey(strs[1]))
                        Cards.SSR.Add(strs[1], strs[2]);
                    break;
                case "SR":
                    if (!Cards.SR.ContainsKey(strs[1]))
                        Cards.SR.Add(strs[1], strs[2]);
                    break;
                case "R":
                    if (!Cards.R.ContainsKey(strs[1]))
                        Cards.R.Add(strs[1], strs[2]);
                    break;
                case "N":
                    if (!Cards.N.ContainsKey(strs[1]))
                        Cards.N.Add(strs[1], strs[2]);
                    break;
                default:

                    Console.WriteLine("Error! Unknown Card Type!");
                    break;
            }
        }
    }

    //static void Main()
    //{
    //    readCardConfiguration();
    //}

}
