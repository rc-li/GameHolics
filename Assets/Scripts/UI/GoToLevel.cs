using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    public void Continue()
    {
        //SceneFader sceneFader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        //GameStatus gameStatus = GameObject.Find("GameManager").GetComponent<GameStatus>();
        SceneManager.LoadScene("Level" + GlobalSceneManager.sceneIndex);
    }

    public void Back()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
