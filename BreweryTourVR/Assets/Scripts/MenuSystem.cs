using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{
    
    public XRController left;
    public InputHelpers.Button menu;
    public GameObject menuSystem;

    public Text[] allText;



    void Start()
    {
        menuSystem.SetActive(false);
    }

    void Update()
    {
        if (left)
        {
            menuSystem.SetActive(CheckIfActivated(left));
        }  
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, menu, out bool isActivated);
        return isActivated;
    }

    public void ChangeTextColorBlack()
    {
        foreach (var item in allText)
        {
            item.color = Color.black;
        }
    }

    public void ChangeTextColorWhite()
    {
        foreach (var item in allText)
        {
            item.color = Color.white;
        }
    }
}

