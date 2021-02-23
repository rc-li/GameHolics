using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WaveSpawner : MonoBehaviour
{
    public static int aliveEnemyNumber;

    public Transform spawnPoint;
    public Wave[] waves;

    public float timeBetweenWaves = 5.0f;
    private float countdown = 2.0f;
    private int waveIndex = 0;

    // public Text waveCountdownText;


    void Update()
    {
        if (aliveEnemyNumber > 0) {
            return;
        }

        if (waveIndex == waves.Length) {
            return;
        }

        if (countdown <= 0.0f) {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0.0f, Mathf.Infinity);

        // waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    IEnumerator SpawnWave() {

        // PlayerStatus.Rounds++ ;

        Wave wave = waves[waveIndex];

        aliveEnemyNumber = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy); 
            yield return new WaitForSeconds(1.0f / wave.rate);
        }

        waveIndex++;     
    }

    void SpawnEnemy(GameObject enemy) {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        // aliveEnemyNumber++;
    }
}
