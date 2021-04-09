using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevelMenu : MonoBehaviour
{
    private SceneFader sceneFader;
    private GameStatus gameStatus;
    private GameObject winLevelMenu;
    private string mainMenu = "LevelSelector";

    private void Awake()
    {
        sceneFader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        gameStatus = GameObject.Find("GameManager").GetComponent<GameStatus>();
        winLevelMenu = GameObject.Find("WinLevelMenu");
    }

    private void Start()
    {
        winLevelMenu.SetActive(false);
    }

    public void Continue()
    {
        sceneFader.FadeToScene(gameStatus.nextLevelName);
    }

    public void Menu()
    {
        sceneFader.FadeToScene(mainMenu);
    }
}
