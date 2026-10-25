using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class Settings : MonoBehaviour
{

    public Text FullScreenText;
    public GameObject settingsTab;
    public Text VolumeText;


    public void Start()
    {
       int soundVar = PlayerPrefs.GetInt("Sound", 1);
        if (soundVar == 1)
        {
            VolumeText.text = "Volume: ON";
        }
        else
        {
            VolumeText.text = "Volume: OFF";
        }
        int fullvar = PlayerPrefs.GetInt("Full", 1);
        if (fullvar == 1)
        {
            FullScreenText.text = "Fullscreen: ON";
            Screen.fullScreen = true;
        } else
        {
            FullScreenText.text = "Fullscreen: OFF";
            Screen.fullScreen = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void openSetting()
    {
        settingsTab.SetActive(true);
    }
    public void closeSetting()
    {
        settingsTab.SetActive(false);
    }
    public void toggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        
        
        if (Screen.fullScreen == false)
        {
            FullScreenText.text = "Fullscreen: ON";
            PlayerPrefs.SetInt("Full", 1);
        }
        if (Screen.fullScreen == true)
        {
            FullScreenText.text = "Fullscreen: OFF";
            PlayerPrefs.SetInt("Full", 0);
        }
        
    }
    public void toggleSound()
    {
        int soundVar = PlayerPrefs.GetInt("Sound", 1);
        if(soundVar == 1)
        {
            PlayerPrefs.SetInt("Sound", 0);
            VolumeText.text = "Volume: OFF";
        } else
        {
            PlayerPrefs.SetInt("Sound", 1);
            VolumeText.text = "Volume: ON";
        }
        
    }
}
