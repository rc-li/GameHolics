using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{

    private bool gameOver = false;

    void Update()
    {
        if (gameOver) return;
        if (PlayerStatus.lives <= 0) GameOver();
    }

    private void GameOver() {
        gameOver = true;
        Debug.Log("Game Over");         
    }
}
