using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChracterSelect : MonoBehaviour
{
    public Image[] images;
    public Text[] texts;
    public const int maxSize = 6;
    public int availabeMinIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Image image in images)
            image.enabled = false;
        SelectedCharacters.images = images;
        SelectedCharacters.texts = texts;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

}
