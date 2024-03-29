﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private GameObject pauseMenu;
    private SceneFader sceneFader;
    private string mainMenu = "StartMenu";


    private void Awake()
    {
        sceneFader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        pauseMenu = GameObject.Find("PauseMenu");
    }

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    public void Restart()
    {
        Toggle();
        sceneFader.FadeToScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Toggle();
        sceneFader.FadeToScene(mainMenu);
    }
}
