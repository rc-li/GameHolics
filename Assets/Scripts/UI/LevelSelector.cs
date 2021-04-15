using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader sceneFader;
    public Button[] levelButtons;
    public Button resetButton;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1> levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void SelectLevel(string levelName)
    {
        //stored integration
        int sceneIndex = levelName[levelName.Length - 1] - '0';
        GlobalSceneManager.sceneIndex = sceneIndex;
        sceneFader.FadeToScene("CharacterSelect");
        //sceneFader.FadeToScene(levelName);
    }

    public void ResetLevel() {
        PlayerPrefs.SetInt("levelReached", 1);
        sceneFader.FadeToScene("LevelSelector");
    }

    public void StartMenu() {
        sceneFader.FadeToScene("StartMenu");
    }
}
