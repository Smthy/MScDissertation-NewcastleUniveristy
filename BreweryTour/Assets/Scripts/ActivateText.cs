using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour
{
    public GameObject text;
    public void _ActivateText()
    {
        text.SetActive(true);
    }
}
