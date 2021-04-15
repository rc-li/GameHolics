using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevelMenu : MonoBehaviour
{
    private SceneFader sceneFader;
    private GameStatus gameStatus;
    private GameObject winLevelMenu;
    private string mainMenu = "StartMenu";


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
        SelectedCharacters.clear();
        GlobalSceneManager.sceneIndex += 1;
        sceneFader.FadeToScene("CharacterSelect");
    }

    public void Menu()
    {
        SelectedCharacters.clear();
        sceneFader.FadeToScene(mainMenu);
    }
}
