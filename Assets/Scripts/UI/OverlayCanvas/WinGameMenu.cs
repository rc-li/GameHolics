using UnityEngine;

public class WinGameMenu : MonoBehaviour
{

    private SceneFader sceneFader;
    private GameObject winGameMenu;
    private string mainMenu = "LevelSelector";

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
        sceneFader.FadeToScene(mainMenu);
    }
}
