using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGameMenu : MonoBehaviour
{

    private SceneFader sceneFader;
    private GameStatus gameStatus;
    private GameObject winGameMenu;
    private string mainMenu = "StartMenu";
    private string creditScreen = "Credits";


    private void Awake()
    {
        sceneFader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        winGameMenu = GameObject.Find("WinGameMenu");
    }

    private void Start()
    {
        winGameMenu.SetActive(false);
    }

    public void Menu()
    {
        SelectedCharacters.clear();
        sceneFader.FadeToScene(mainMenu);
    }

    public void LoadCreditScreen()
    {
        SelectedCharacters.clear();
        sceneFader.FadeToScene(creditScreen);
    }
}
