using UnityEngine;

public class WinLevelMenu : MonoBehaviour
{
    public SceneFader sceneFader;
    public GameObject winLevelMenu;
    public GameStatus gameStatus;
    private string mainMenu = "LevelSelector";

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
