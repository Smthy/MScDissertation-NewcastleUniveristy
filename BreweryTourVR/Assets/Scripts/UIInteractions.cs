using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class UIInteractions : MonoBehaviour
{
    public GameObject starterText, settingLayer, teleportLayer, mainMenuLayer;
    public CharacterController userController;
    public GameObject user;
    public Transform[] teleportTransforms;
    public AudioListener audioListener;
    public Text volumeText;
    

    private void Start()
    {
        settingLayer.SetActive(false);        
        teleportLayer.SetActive(false);
        mainMenuLayer.SetActive(true);

    }

    private void Update()
    {
        volumeText.text = AudioListener.volume.ToString();
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

    /*
     * play fade in
     * teleport to location
     * play fade out
    */ 

    public void KettleTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[0].transform.position;
        userController.enabled = true;
    }

    public void MasherTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[1].transform.position;
        userController.enabled = true;
    }

    public void FermTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[2].transform.position;
        userController.enabled = true;
    }

    public void CoolingTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[3].transform.position;
        userController.enabled = true;
    }

    public void PressurisedTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[4].transform.position;
        userController.enabled = true;
    }

    public void Liter800Teleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[5].transform.position;
        userController.enabled = true;
    }

    public void coolingPanelTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[6].transform.position;
        userController.enabled = true;
    }

    public void liter400Teleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[7].transform.position;
        userController.enabled = true;
    }

    public void MiddleTeleportation()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[8].transform.position;
        userController.enabled = true;
    }

    public void Underback()
    {
        userController.enabled = false;
        user.transform.position = teleportTransforms[9].transform.position;
        userController.enabled = true;
    }

    public AudioListener GetAudioListener()
    {
        return audioListener;
    }

    public void IncreaseAudio()
    {
        if(AudioListener.volume != 1)
        {
            AudioListener.volume += 0.1f;
        }
        else
        {
            AudioListener.volume = 1;
        }      

    }

    public void DecreaseAudio()
    {
        if (AudioListener.volume != 0)
        {
            AudioListener.volume -= 0.1f;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
