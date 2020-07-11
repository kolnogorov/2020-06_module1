using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    enum Screen
    {
        None,
        Main,
        Settings,
        LevelSelect,
    }

    public CanvasGroup mainScreen;
    public CanvasGroup settingsScreen;
    public CanvasGroup levelSelectScreen;
    string currentLevel;

    void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(mainScreen, screen == Screen.Main);
        Utility.SetCanvasGroupEnabled(settingsScreen, screen == Screen.Settings);
        Utility.SetCanvasGroupEnabled(levelSelectScreen, screen == Screen.LevelSelect);
    }

    void Awake()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void StartNewLevel(string level)
    {
        currentLevel = level;
        SetCurrentScreen(Screen.None);
        LoadingScreen.instance.LoadScene(level);
    }

    public void OpenSettings()
    {
        SetCurrentScreen(Screen.Settings);
    }

    public void OpenMainMenu()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void LevelSelectSettings()
    {
        SetCurrentScreen(Screen.LevelSelect);
    }

    public void RestartLevel()
    {
        StartNewLevel(currentLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
