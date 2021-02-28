using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WaveSpawner : MonoBehaviour
{
    public static int aliveEnemyNumber;

    public Transform spawnPoint;
    public Wave[] waves;
    public GameStatus gameStatus;

    public float timeBetweenWaves = 5.0f;
    private float countdown = 2.0f;
    private int waveIndex = 0;

    // public Text waveCountdownText;

    private void Start()
    {
        aliveEnemyNumber = 0;
    }

    private void Update()
    {
        if (aliveEnemyNumber > 0)
        {
            return;
        }

        if (waveIndex == waves.Length)
        {
            //if there is no sceneFader at next level, It means we have reached last level (prevent NPE problem for now, it can be modified later)
            // if (gameStatus.sceneFader != null)
            // {
            gameStatus.WinLevel();
            enabled = false;
            // } 
            // return;
        }

        if (countdown <= 0.0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0.0f, Mathf.Infinity);
        // waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    IEnumerator SpawnWave()
    {
        PlayerStatus.Rounds++;
        Wave wave = waves[waveIndex];
        //Fixed previous spawner bug, initialize the aliveNumber as 0
        aliveEnemyNumber = 0;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1.0f / wave.rate);
        }

        waveIndex++;
    }

    void SpawnEnemy(Enemy enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        aliveEnemyNumber++;
    }
}
