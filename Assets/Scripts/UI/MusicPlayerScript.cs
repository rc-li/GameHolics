using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider volumeSlider;
    private float musicVolume = 1f;

    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.Play();

        AudioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    void Update()
    {
        AudioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    // what's this function for?
    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
