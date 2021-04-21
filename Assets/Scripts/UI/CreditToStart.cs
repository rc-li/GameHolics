using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreditToStart : MonoBehaviour
{
    public SceneFader sceneFader;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMenu",31);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        sceneFader.FadeToScene("StartMenu");
    }
}
