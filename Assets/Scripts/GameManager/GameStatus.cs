using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameStatus : MonoBehaviour
{
    private GameObject winLevelMenu;
    private WinLevelMenu _winLevelMenu;
    private GameObject winGameMenu;
    private GameObject gameOverMenu;
    public static bool gameIsOver;
    private const int LAST_LEVEL = 5;
    private int reachedLevelNumber;
    private int savedLevelNumber;
    public string reachedLevelName;


    private void Awake()
    {
        winLevelMenu = GameObject.Find("WinLevelMenu");
        winGameMenu = GameObject.Find("WinGameMenu");
        gameOverMenu = GameObject.Find("GameOverMenu");
    }

    private void Start()
    {
        gameIsOver = false;
        reachedLevelName = SceneManager.GetActiveScene().name;
        reachedLevelNumber = Int32.Parse(reachedLevelName.Substring(reachedLevelName.Length - 1));
        savedLevelNumber = PlayerPrefs.GetInt("levelReached", 0);
        //GlobalInitializer.readCardConfiguration();
    }

    private void Update()
    {
        if (gameIsOver)
        {
            return;
        }

        if (PlayerStatus.lives <= 0) GameOver();
    }

    public void GameOver()
    {
        gameIsOver = true;
        PlayerStatus.Rounds--;
        gameOverMenu.SetActive(true);
    }

    public void WinLevel()
    {
        gameIsOver = true;

        if (reachedLevelNumber < LAST_LEVEL)
        {
            winLevelMenu.SetActive(true);
            SetNextLevel();
        }

        else if (reachedLevelNumber == LAST_LEVEL)
        {
            WinGame();
        }
    }

    private void SetNextLevel()
    {
        reachedLevelNumber++;
        if (reachedLevelNumber > savedLevelNumber)
        {
            PlayerPrefs.SetInt("levelReached", reachedLevelNumber);
        }
        Debug.Log("savedLevelNumber" + savedLevelNumber);
    }


    private void WinGame()
    {
        gameIsOver = true;
        winGameMenu.SetActive(true);
    }
}
