using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static int aliveEnemyNumber;
    public Transform[] spawnPoints;
    // public GameObject[] spawnPoints;

    public Wave[] waves;
    public GameStatus gameStatus;
    public float timeBetweenWaves = 5.0f;
    public float countdown = 2.0f;
    public int waveIndex = 0;
    public static int randomSpawn;
    private Text waveCountdownText;

    private void Awake()
    {
        Text[] topCanvasTexts = GameObject.Find("TopCanvas").GetComponentsInChildren<Text>();
        foreach (var text in topCanvasTexts)
        {
            if (text.name == "waveCountdownText")
            {
                waveCountdownText = text;
                return;
            }
        }
    }
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

        if (waveIndex == waves.Length && PlayerStatus.lives > 0)
        {
            //if there is no sceneFader at next level, It means we have reached last level (prevent NPE problem for now, it can be modified later)
            // if (gameStatus.sceneFader != null)
            gameStatus.WinLevel();
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
        waveCountdownText.text = string.Format("NEXT WAVE  {0:00.00}", countdown);
    }

    IEnumerator SpawnWave()
    {
        PlayerStatus.Rounds++;
        Wave wave = waves[waveIndex];

        for (int i = 0; i < wave.waveEnemy.Length; i++)
        {
            aliveEnemyNumber += wave.waveEnemy[i].enemyNumber;
        }
        // Debug.Log("aliveEnemyNumber:" + aliveEnemyNumber);

        for (int i = 0; i < wave.waveEnemy.Length; i++)
        {
            for (int j = 0; j < wave.waveEnemy[i].enemyNumber; j++)
            {
                SpawnEnemy(wave.waveEnemy[i].enemy);
                yield return new WaitForSeconds(1.0f / wave.rate);
            }
        }

        if (waveIndex <= waves.Length - 1)
        {
            waveIndex++;
        }
    }

    void SpawnEnemy(Enemy enemy)
    {
        // int num = random.Next(1000);
        // System.Random rnd = new System.Random();
        // int single = rnd.Next(1, 10);
        // Debug.Log("single" + single);
        // int Random.Range Return a random int within [minInclusive..maxExclusive) (Read Only)
        // randomSpawn = UnityEngine.Random.Range(0, spawnPoints.Length);
        System.Random rnd = new System.Random();
        randomSpawn = rnd.Next(0, spawnPoints.Length);

        // GameObject spawnPoint = spawnPoints[randomSpawn];
        // Debug.Log(spawnPoint.name);
        Debug.Log(spawnPoints[randomSpawn].name);
        Instantiate(enemy, spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);
    }
}
