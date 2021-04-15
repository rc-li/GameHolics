using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private SceneFader sceneFader;
    private GameStatus gameStatus;
    private GameObject gameOverMenu;
    private string mainMenu = "StartMenu";


    private void Awake()
    {
        sceneFader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        gameStatus = GameObject.Find("GameManager").GetComponent<GameStatus>();
        gameOverMenu = GameObject.Find("GameOverMenu");
    }

    private void Start()
    {
        gameOverMenu.SetActive(false);
    }

    public void Restart()
    {
        sceneFader.FadeToScene(gameStatus.reachedLevelName);
    }

    public void Menu()
    {
        sceneFader.FadeToScene(mainMenu);
    }
}
