using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavesUI : MonoBehaviour
{

    private WaveSpawner waveSpawner;
    private int currentWave = 0;
    private int displayCurrentWave = 1;
    private int totalWave;
    private Text waveText;


    private void Awake()
    {
        waveSpawner = GameObject.Find("GameManager").GetComponentInChildren<WaveSpawner>();
    }

    void Start()
    {
        totalWave = waveSpawner.waves.Length;
        waveText = GetComponentInChildren<Text>();
        waveText.text = "WAVE 0 / " + totalWave.ToString();
    }

    void Update()
    {
        currentWave = waveSpawner.waveIndex + 1;

        if (waveSpawner.countdown == 0)
        {
            displayCurrentWave = currentWave;
            waveText.text = "WAVE " + displayCurrentWave.ToString() + " / " + totalWave.ToString();
        }
    }
}
