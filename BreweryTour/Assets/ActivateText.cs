using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour
{
    public GameObject text;   

    // Start is called before the first frame update
    void Start()
    {
        if (!text.active)
        {
            return;
        }
        text.SetActive(false);
    }

    public void _ActivateText()
    {
        text.SetActive(true);
    }
}
