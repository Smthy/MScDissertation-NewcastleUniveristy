using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftRay;
    public InputHelpers.Button teleportActivator;
    public float activationThresold = 0.1f;

    void Update()
    {
        if (leftRay)
        {
            leftRay.gameObject.SetActive(CheckIfActivated(leftRay));
        }

        //if (rightRay)
        //{
        //    rightRay.gameObject.SetActive(CheckIfActivated(rightRay));
        //}
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivator, out bool isActivated, activationThresold);
        return isActivated;
    }
}
