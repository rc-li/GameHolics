using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//这个是主页面的script
public class DrawCards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Go to the card Drawer Scene
    public void onDrawCard()
    {
        SceneManager.LoadScene("CharacterCalling");
    }
}
