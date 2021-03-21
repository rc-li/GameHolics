using UnityEngine;

public class WinGameMenu : MonoBehaviour
{

    public SceneFader sceneFader;
    public GameObject winGameMenu;
    private string mainMenu = "LevelSelector";

    private void Start()
    {
        winGameMenu.SetActive(false);
    }

    public void Menu()
    {
        sceneFader.FadeToScene(mainMenu);
    }
}
