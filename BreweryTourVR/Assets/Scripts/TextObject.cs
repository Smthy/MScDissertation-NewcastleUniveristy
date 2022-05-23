using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextObject : MonoBehaviour
{
    public GameObject[] textObjects;

    void Awake()
    {
        if(textObjects == null)
            textObjects = GameObject.FindGameObjectsWithTag("TextObject");
        
        
        foreach (GameObject item in textObjects)
        {
            item.SetActive(false);
        }
    }    
}
