using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    public WaveEnemy[] waveEnemy;
    public int count = 0;
    public float rate;


    private void Start() {
        for (int i = 0; i < waveEnemy.Length; i++)
        {
            count += waveEnemy[i].enemyNumber;
            Debug.Log(count);
        }
    }
}
