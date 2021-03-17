using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutscenePlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip videoClip;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += onMovieEnded;
    }

    //// Update is called once per frame
    void Update()
    {
        //if (!videoPlayer.isPlaying)
        //{
        //    SceneManager.LoadScene("StartMenu");
        //}
    }

    void onMovieEnded(VideoPlayer videoPlayer)
    {
        SceneManager.LoadScene("StartMenu");
    }
}
