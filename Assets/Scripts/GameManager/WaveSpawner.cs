using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WaveSpawner : MonoBehaviour
{
    public static int aliveEnemyNumber;

    public Transform[] spawnPoints;
    public Wave[] waves;
    public GameStatus gameStatus;

    public float timeBetweenWaves = 5.0f;
    private float countdown = 2.0f;
    private int waveIndex = 0;
    public static int randomSpawn;

    // public Text waveCountdownText;

    private void Start()
    {
        aliveEnemyNumber = 0;
        // spawnPoints = GetComponentInChildren<Transform>();
    }

    private void Update()
    {
        Debug.Log(aliveEnemyNumber);

        if (aliveEnemyNumber > 0)
        {
            return;
        }

        if (waveIndex == waves.Length && PlayerStatus.lives > 0)
        {
            //if there is no sceneFader at next level, It means we have reached last level (prevent NPE problem for now, it can be modified later)
            // if (gameStatus.sceneFader != null)
            gameStatus.WinLevel();
            Debug.Log("win_level");
            enabled = false;
            return;
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
        aliveEnemyNumber = wave.count;


        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1.0f / wave.rate);
        }

        if (waveIndex <= waves.Length - 1)
        {
            waveIndex++;
            // Debug.Log("====" + waveIndex);
        }
    }

    void SpawnEnemy(Enemy enemy)
    {
        // int Random.Range Return a random int within [minInclusive..maxExclusive) (Read Only)
        randomSpawn = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);
        // aliveEnemyNumber++;
    }
}
