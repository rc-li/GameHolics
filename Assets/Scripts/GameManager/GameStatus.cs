using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{

    // public static bool gameOver;

    public GameObject winLevelMenu;
    private WinLevelMenu _winLevelMenu;

    public GameObject winGameMenu;
    private int totalLevels = 2;
    public string nextLevelName;

    public GameObject gameOverMenu;
    public string currentLevelName;
    private int currentLevel;

    private void Start()
    {
        // gameOver = false;
        currentLevel = SceneManager.GetActiveScene().buildIndex;

    }

    // private void Update()
    // {
    //     if (gameOver) return;
    //     if (PlayerStatus.lives <= 0) EndGame();
    // }

    public void GameOver()
    {
        PlayerStatus.Rounds--;
        currentLevelName = GetSceneNameByBuildIndex(currentLevel);
        gameOverMenu.SetActive(true);
        return;
    }

    public void WinLevel()
    {
        if (currentLevel < totalLevels)
        {
            winLevelMenu.SetActive(true);
            SetNextLevel(currentLevel);
            return;
        }
        WinGame();
    }

    public void SetNextLevel(int _currentLevel)
    {
        int nextLevel = _currentLevel + 1;
        PlayerPrefs.SetInt("levelReached", nextLevel);
        nextLevelName = GetSceneNameByBuildIndex(nextLevel);
        // Debug.Log("nextLevelName:" + nextLevelName);
    }

    public string GetSceneNameByBuildIndex(int buildIndex)
    {
        string path = SceneUtility.GetScenePathByBuildIndex(buildIndex);
        string sceneName = path.Substring(0, path.Length - 6).Substring(path.LastIndexOf('/') + 1);
        return sceneName;
    }

    private void WinGame()
    {
        winGameMenu.SetActive(true);
    }
}
