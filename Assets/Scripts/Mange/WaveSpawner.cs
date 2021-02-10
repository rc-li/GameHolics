using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public Transform minionPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves;
    private float countdown;

    private int waveIndex;

    void Start()
    {
        timeBetweenWaves = 5.0f;
        countdown = 2.0f; 
        waveIndex = 1;  
    }

    void Update()
    {
        if (countdown <= 0.0f) {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;     
    }

    IEnumerator SpawnWave() {
        waveIndex ++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnMinion(); 
            yield return new WaitForSeconds(0.7f);
        }
        
    }

    void SpawnMinion() {
        Instantiate(minionPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
