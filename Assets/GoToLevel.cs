using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void Continue()
    {
        SceneFader sceneFader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        GameStatus gameStatus = GameObject.Find("GameManager").GetComponent<GameStatus>();
        sceneFader.FadeToScene(gameStatus.nextLevelName);
    }
}
