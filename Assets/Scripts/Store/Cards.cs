using System;
using System.Collections.Generic;
using System.Linq;

public static class Cards
{
    //Lazy Initialization, not good
    //应该在之后在进行这个步骤，以优化启动游戏速度
    //在启动游戏的时候应该只加载必要的配置
    public static Dictionary<string, string> SSR = new Dictionary<string, string>();
    public static Dictionary<string, string> SR = new Dictionary<string, string>();
    public static Dictionary<string, string> R = new Dictionary<string, string>();
    public static Dictionary<string, string> N = new Dictionary<string, string>();

    public static Dictionary<string,string> getDictionaryByRarity(Rarity rarity)
    {
        switch (rarity)
        {
            case Rarity.SSR:
                return SSR;
            case Rarity.SR:
                return SR;
            case Rarity.R:
                return R;
            case Rarity.N:
                return N;
            default:
                break;
        }
        return null;
    }

    //public const string BASIC_PITCHER = "TowerType1";
    public static string[] getTenCards(Rarity[] rarities)
    {
        string[] res = new string[10];
        int i = 0;
        foreach (Rarity rarity in rarities)
        {
            switch (rarity)
            {
                case Rarity.SSR:
                    res[i++] = SSR.Keys.ElementAt(GlobalRandom.getInstance().Next(0, SSR.Count));
                    break;
                case Rarity.SR:
                    res[i++] = SR.Keys.ElementAt(GlobalRandom.getInstance().Next(0, SR.Count));
                    break;
                case Rarity.R:
                    res[i++] = R.Keys.ElementAt(GlobalRandom.getInstance().Next(0, R.Count));
                    break;
                case Rarity.N:
                    res[i++] = N.Keys.ElementAt(GlobalRandom.getInstance().Next(0, N.Count));
                    break;
                default:
                    break;
            }
        }

        addCardsToPlayerPool(res);
        return res;
    }

    private static void addCardsToPlayerPool(string[] cards)
    {
        foreach (string card in cards)
            GlobalPlayer.cards.Add(card);
    }
}
