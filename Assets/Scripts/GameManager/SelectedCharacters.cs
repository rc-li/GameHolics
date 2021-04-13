using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using UnityEngine.UI;

//全局唯一
public static class SelectedCharacters
{
    public static string[] selectedCharacters = new string[6]
    {null,null,null,null,null,null };
    public static Image[] images;
    public static Text[] texts;
    //public static string[] selectedCharacters = { "TowerType1", "TowerType2" , "TowerType3" , "TowerType4" , "TowerType5" , "TowerType6" };
    private static int MAX_CHARACTER = 6;

    //
    public static void setCharacters(string[] characters)
    {
        for (int i = 0; i < MAX_CHARACTER; i++)
        {
            selectedCharacters[i] = characters[i];
        }
    }

    public static int addACardToSelectedSet(string characterName)
    {
        for (int i = 0; i < selectedCharacters.Count(); i++)
        {
            if (selectedCharacters[i] == null)
            {
                selectedCharacters[i] = characterName;
                return i;
            }
        }
        return -1;
    }

    public static void clear()
    {
        for (int i = 0; i < MAX_CHARACTER; i++)
        {
            //images[i] = null;
            //texts[i] = null;
            selectedCharacters[i] = null;
        }
    }
}
