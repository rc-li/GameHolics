using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SceneFader sceneFader;
    
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadStore()
    {
        SceneManager.LoadScene("CharacterCalling");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void LoadSelectCharacters()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    public void LoadLevelSelector()
    {
        sceneFader.FadeToScene("LevelSelector");
    }

    public void LoadCreditScreen()
    {
        SceneManager.LoadScene("Credits");
    }
}
