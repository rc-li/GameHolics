using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider volumeSlider;
    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.Play();
        
        AudioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void updateVolume( float volume)
    {
        musicVolume = volume;
    }
}
