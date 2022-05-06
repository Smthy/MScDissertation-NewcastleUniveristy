using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextObject : MonoBehaviour
{
    public GameObject[] textObjects;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (var item in textObjects)
        {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
