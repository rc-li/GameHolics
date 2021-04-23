using System;
using System.IO;

public static class GlobalInitializer
{
    private static string CARD_CONFIGURATION = "/Assets/Scripts/Cards.csv";
    private static string PREFAB_PREFIX = "";

    //从卡牌配置文档之中读取卡牌信息
    public static void readCardConfiguration()
    {
        var lines = File.ReadAllLines(System.Environment.CurrentDirectory
            + CARD_CONFIGURATION);
        foreach (var line in lines)
        {
            string[] strs = line.Split(',');
            if (!Cards.all.ContainsKey(strs[0]))
            {
                Cards.all.Add(strs[0], strs[1]);
                CardProperty cardProperty = new CardProperty();
                cardProperty.name = strs[0];
                cardProperty.range = float.Parse(strs[3]);
                cardProperty.fireRate = float.Parse(strs[4]);
                cardProperty.speed = float.Parse(strs[5]);
                cardProperty.slowPercent = float.Parse(strs[6]);
                cardProperty.damage = int.Parse(strs[7]);
                cardProperty.cost = int.Parse(strs[8]);
                Cards.cardProperties.Add(strs[0], cardProperty);
            }
            switch (strs[2])
            {
                case "SSR":
                    if (!Cards.SSR.ContainsKey(strs[0]))
                        Cards.SSR.Add(strs[0], strs[1]);
                    break;
                case "SR":
                    if (!Cards.SR.ContainsKey(strs[0]))
                        Cards.SR.Add(strs[0], strs[1]);
                    break;
                case "R":
                    if (!Cards.R.ContainsKey(strs[0]))
                        Cards.R.Add(strs[0], strs[1]);
                    break;
                case "N":
                    if (!Cards.N.ContainsKey(strs[0]))
                        Cards.N.Add(strs[0], strs[1]);
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
