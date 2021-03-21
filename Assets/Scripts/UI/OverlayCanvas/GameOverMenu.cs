using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public SceneFader sceneFader;
    public GameStatus gameStatus;
    public GameObject gameOverMenu;
    private string mainMenu = "LevelSelector";

    private void Start() {
        gameOverMenu.SetActive(false);
    }
    
    public void Restart() {
        sceneFader.FadeToScene(gameStatus.currentLevelName);
    }

    public void Menu() {
        sceneFader.FadeToScene(mainMenu);
    }
}
