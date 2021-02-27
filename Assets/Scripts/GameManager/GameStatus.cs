using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{

    public static bool gameOver;

    public GameObject winLevelMenu;
    private WinLevelMenu _winLevelMenu;

    public GameObject winGameMenu;
    private int totalLevels = 2;
    public string nextLevelName;

    private void Start()
    {
        gameOver = false;
    }

    private void Update()
    {
        if (gameOver) return;
        if (PlayerStatus.lives <= 0) EndGame();
    }

    public void EndGame()
    {
        gameOver = true;
        Debug.Log("Game Over");
    }

    public void WinLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
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
