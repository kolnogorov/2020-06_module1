using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    void Start()
    {
        CloseMenu();
    }

    public void OpenMenu()
    {
        gameObject.SetActive(true);
    }

    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }

    public void RestartLevel()
    {
        CloseMenu();
        LoadingScreen.instance.ReloadCurrentScene();
    }

    public void NextLevel(string level)
    {
        CloseMenu();
        LoadingScreen.instance.LoadScene(level);
    }

    public void ExitMainMenu()
    {
        CloseMenu();
        LoadingScreen.instance.LoadScene("MainMenu");
    }
}
