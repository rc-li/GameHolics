using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    private GameObject winLevelMenu;
    private WinLevelMenu _winLevelMenu;
    private GameObject winGameMenu;
    private GameObject gameOverMenu;
    public static bool gameIsOver;
    //在build setting里面 的 最后一个level所对应的scend Index
    private const int LAST_LEVEL = 7;
    public string nextLevelName;
    public string currentLevelName;
    private int currentLevel;

    private void Awake()
    {
        winLevelMenu = GameObject.Find("WinLevelMenu");
        winGameMenu = GameObject.Find("WinGameMenu");
        gameOverMenu = GameObject.Find("GameOverMenu");
    }

    private void Start()
    {
        gameIsOver = false;
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        System.Console.WriteLine(currentLevel);
        //GlobalInitializer.readCardConfiguration();
    }

    private void Update()
    {
        if (gameIsOver)
        {
            return;
        }

        if (PlayerStatus.lives <= 0) GameOver();
    }

    public void GameOver()
    {
        gameIsOver = true;
        PlayerStatus.Rounds--;
        currentLevelName = GetSceneNameByBuildIndex(currentLevel);
        gameOverMenu.SetActive(true);
    }

    public void WinLevel()
    {
        gameIsOver = true;

        if (currentLevel < LAST_LEVEL)
        {
            winLevelMenu.SetActive(true);
            SetNextLevel(currentLevel);
        }

        else if (currentLevel == LAST_LEVEL)
        {
            WinGame();
        }

    }

    public void SetNextLevel(int _currentLevel)
    {
        int nextLevel = _currentLevel + 1;
        PlayerPrefs.SetInt("levelReached", nextLevel - 2);
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
        gameIsOver = true;
        winGameMenu.SetActive(true);
    }
}
