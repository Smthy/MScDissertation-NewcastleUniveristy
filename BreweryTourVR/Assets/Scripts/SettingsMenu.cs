using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Text[] text;

    private void Awake()
    {
        if(text == null)
        {
            text = FindObjectsOfType<Text>();
        }
    }

    public void TextToBlack()
    {
        foreach(var item in text)
        {
            item.color = Color.black;
        }
    }

    public void TextToWhite()
    {
        foreach (var item in text)
        {
            item.color = Color.white;
        }
    }

}
