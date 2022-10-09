using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void PlayButton()
    {
        Debug.Log("Play Button Clicked");
        Debug.Log("In Game..");
        Debug.Log("Return to Main Menu..");
    }

    public void SettingsButton()
    {
        Debug.Log("Settings Button Clicked");
        SceneManager.LoadScene("SettingScene");
    }

    public void QuitButton()
    {
        Debug.Log("Quit Button Clicked");
        Application.Quit();
    }
}
