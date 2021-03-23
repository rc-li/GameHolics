using System;
using System.IO;

public static class GlobalInitializer
{
    //从卡牌配置文档之中读取卡牌信息
    public static void readCardConfiguration()
    {
        var lines = File.ReadAllLines(System.Environment.CurrentDirectory
            + "/Assets/Scripts/Cards.csv");
        foreach (var line in lines)
        {
            string[] strs = line.Split(',');
            switch (strs[2])
            {
                case "SSR":
                    if(!Cards.SSR.ContainsKey(strs[0]))
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
