using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreditToStart : MonoBehaviour
{
    public SceneFader sceneFader;

    void Start()
    {
        Invoke("LoadMenu", 26);
    }

    void Update()
    {

    }

    public void LoadMenu()
    {
        sceneFader.FadeToScene("StartMenu");
    }
}
