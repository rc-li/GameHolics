using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{

    public static bool gameOver;
    public string nextLevelName = "Level2";
    public int nextLevel = 2;
    public SceneFader sceneFader;

    private void Start()
    {
        gameOver = false;
    }

    private void Update()
    {
        if (gameOver) return;
        if (PlayerStatus.lives <= 0) EndGame();
    }

    public void EndGame()
    {
        gameOver = true;
        Debug.Log("Game Over");
    }

    public void WinLevel()
    {
        Debug.Log("win level");
        PlayerPrefs.SetInt("levelReached", nextLevel);
        sceneFader.FadeToScene(nextLevelName);
    }
}
