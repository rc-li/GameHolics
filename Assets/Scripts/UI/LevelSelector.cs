using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButtons;

    private void Start()
    {

        int _levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > _levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void SelectLevel(string levelName)
    {
        fader.FadeToScene(levelName);
    }

}
