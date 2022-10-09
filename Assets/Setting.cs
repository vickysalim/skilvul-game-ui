using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Setting : MonoBehaviour
{
    // audio
    public AudioSource audioSource;

    // toggle mute
    [SerializeField] Toggle toggleMute;
    
    public void MuteSound()
    {
        audioSource.mute = toggleMute.isOn;
        Debug.Log("Mute Toggle: " + toggleMute.isOn);
    }

    // slider volume
    [SerializeField] Slider sliderVolume;
    [SerializeField] TMP_Text textVolume;

    public void ChangeVolume()
    {
        audioSource.volume = sliderVolume.value / 100;
        textVolume.text = "Volume (" + sliderVolume.value + "%)";
        Debug.Log("Volume: " + sliderVolume.value);
    }

    // dropdown display size
    [SerializeField] TMP_Dropdown dropdownDisplaySize;

    public void ChangeDisplaySize()
    {
        switch(dropdownDisplaySize.value)
        {
            case 0:
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                Debug.Log("Display Size: Fullscreen");
                break;
            case 1:
                Screen.fullScreenMode = FullScreenMode.Windowed;
                Debug.Log("Display Size: Windowed");
                break;
        }
    }

    // dropdown screen resolution
    [SerializeField] TMP_Dropdown dropdownScreenResolution;
    private bool isFullScreen;

    public void ChangeScreenResolution()
    {
        if(dropdownDisplaySize.value == 0)
        {
            isFullScreen = true;
        } else
        {
            isFullScreen = false;
        }

        switch (dropdownScreenResolution.value)
        {
            case 0:
                Screen.SetResolution(3840, 2160, isFullScreen);
                Debug.Log("Screen Resolution: 3840 x 2160");
                break;
            case 1:
                Screen.SetResolution(2560, 1440, isFullScreen);
                Debug.Log("Screen Resolution: 2560 x 1440");
                break;
            case 2:
                Screen.SetResolution(1920, 1080, isFullScreen);
                Debug.Log("Screen Resolution: 1920 x 1080");
                break;
            case 3:
                Screen.SetResolution(1366, 768, isFullScreen);
                Debug.Log("Screen Resolution: 1366 x 768");
                break;
            case 4:
                Screen.SetResolution(1280, 1024, isFullScreen);
                Debug.Log("Screen Resolution: 1280 x 1024");
                break;
            case 5:
                Screen.SetResolution(1280, 720, isFullScreen);
                Debug.Log("Screen Resolution: 1280 x 720");
                break;
            case 6:
                Screen.SetResolution(1024, 768, isFullScreen);
                Debug.Log("Screen Resolution: 1024 x 768");
                break;
        }
    }

    // dropdown graphic quality
    [SerializeField] TMP_Dropdown dropdownGraphicQuality;

    public void ChangeGraphicQuality()
    {
        switch (dropdownGraphicQuality.value)
        {
            case 0:
                QualitySettings.SetQualityLevel(3);
                Debug.Log("Graphic Quality: High");
                break;
            case 1:
                QualitySettings.SetQualityLevel(2);
                Debug.Log("Graphic Quality: Medium");
                break;
            case 2:
                QualitySettings.SetQualityLevel(1);
                Debug.Log("Graphic Quality: Low");
                break;
        }
    }

    // toggle vertical sync
    [SerializeField] Toggle toggleVerticalSync;

    public void VSync()
    {
        if(toggleVerticalSync.isOn)
        {
            QualitySettings.vSyncCount = 1;
        } else
        {
            QualitySettings.vSyncCount = 0;
        }
        Debug.Log("VSync Toggle: " + toggleVerticalSync.isOn);
    }

    // return to main menu button
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Return Button Clicked");
    }
}
