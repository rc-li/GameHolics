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
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void SelectLevel(string levelName)
    {
        sceneFader.FadeToScene(levelName);
    }

    public void ResetLevel() {
        PlayerPrefs.SetInt("levelReached", 1);
        sceneFader.FadeToScene("LevelSelector");
    }

}
