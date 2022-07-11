using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuSystem : MonoBehaviour
{
    
    public XRController left;
    public InputHelpers.Button menu;
    public GameObject menuSystem;



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
}

