using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cutscene : MonoBehaviour
{
    [TextArea(4, 30)]
    public string[] page;
    int pageNumber = -1;
    Text view;


    void Start()
    {
        view = GetComponent<Text>();
        Invoke("PageTurn", 2);
    }


    //void Update()
    //{
    //    if (pageNumber < 0) view.text = "";
    //    if (Input.GetButtonDown("Submit"))
    //}

    void PageTurn ()
    {
        pageNumber++;
        if(pageNumber < page.Length)view.text = page[pageNumber];
        Invoke("PageTurn", 2);
    }

}
