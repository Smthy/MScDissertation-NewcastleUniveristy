using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInteractions : MonoBehaviour
{
    public GameObject starterText;

    public GameObject settingLayer, teleportLayer, mainMenuLayer;

    private void Start()
    {
        settingLayer.SetActive(false);        
        teleportLayer.SetActive(false);
        mainMenuLayer.SetActive(true);
    }


    public void Close()
    {
        starterText.SetActive(false);

    }

    public void TeleportationMenu()
    {
        settingLayer.SetActive(false);
        mainMenuLayer.SetActive(false);        
        teleportLayer.SetActive(true);
    }

    public void SettingsMenu()
    {        
        teleportLayer.SetActive(false);
        mainMenuLayer.SetActive(false);
        settingLayer.SetActive(true);
    }

    public void main()
    {
        settingLayer.SetActive(false);
        teleportLayer.SetActive(false);
        mainMenuLayer.SetActive(true);
    }
}
