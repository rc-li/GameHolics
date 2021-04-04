using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

//全局唯一
public static class SelectedCharacters
{
    public static string[] selectedCharacters = { "TowerType1", "TowerType2" , "TowerType3" , "TowerType4" , "TowerType5" , "TowerType6" };
    private static int MAX_CHARACTER = 6;
    public static int reachedIndex = 0;
    //
    public static void setCharacters(string[] characters)
    {
        for (int i = 0; i < MAX_CHARACTER; i++)
        {
            selectedCharacters[i] = characters[i];
        }
    }
}
