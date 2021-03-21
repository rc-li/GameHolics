using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public enum Rarity
{
    SSR ,
    SR ,
    R ,
    N 
};

public static class CardRate
{
    public static int SSR_RATE = 1;
    public static int SR_RATE = 6;
    public static int R_RATE = 26;

    public static Rarity[] DrawTenCards()
    {
        Rarity[] res = new Rarity[10];
        System.Random random = GlobalRandom.getInstance();
        bool hasSR = false;
        for (int i = 0; i < 9; i++)
        {
            int num = random.Next(0, 100);
            if (num < 1)
            {
                res[i] = Rarity.SSR;
                hasSR = true;
            }
            else if (num < 6)
            {
                res[i] = Rarity.SR;
                hasSR = true;
            }
            else if (num < 26)
                res[i] = Rarity.R;
            else res[i] = Rarity.N;
        }

        if (!hasSR)
            res[9] = Rarity.SR;
        else
        {
            int num = random.Next(0, 100);
            if (num < 1)
            {
                res[9] = Rarity.SSR;
                hasSR = true;
            }
            else if (num < 6)
            {
                res[9] = Rarity.SR;
                hasSR = true;
            }
            else if (num < 26)
                res[9] = Rarity.R;
            else res[9] = Rarity.N;
        }
        return res;
    }
}

public class DrawTenCards : MonoBehaviour
{
    
    public Image card0;
    public Image card1;
    public Image card2;
    public Image card3;
    public Image card4;
    public Image card5;
    public Image card6;
    public Image card7;
    public Image card8;
    public Image card9;

    // Start is called before the first frame update
    void Start()
    {
        Image[] images = new Image[10];
        images[0] = card0;
        images[1] = card1;
        images[2] = card2;
        images[3] = card3;
        images[4] = card4;
        images[5] = card5;
        images[6] = card6;
        images[7] = card7;
        images[8] = card8;
        images[9] = card9;

        Transform[] cards = new Transform[transform.childCount];

        Rarity[] rarityResult = CardRate.DrawTenCards();
        string[] drawResult = Cards.getTenCards(rarityResult);

        for (int i = 0; i < 10; i++)
        {
            string cardPath = Cards.getDictionaryByRarity(rarityResult[i])[drawResult[i]];
            images[i].sprite = Resources.Load(cardPath, typeof(Sprite)) as Sprite;
        }

        for (var i = 0; i < transform.childCount; i++)
        {
            Transform card = transform.GetChild(i);
            cards[i] = card;
        }

        Debug.Log(GlobalPlayer.cards);
        Console.WriteLine(GlobalPlayer.cards);
    }
}
