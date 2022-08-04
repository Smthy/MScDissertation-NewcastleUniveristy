using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public GameObject hideButton;
    void Start()
    {
        hideButton.SetActive(false);
        StartCoroutine("startTime");
    }

    IEnumerator startTime()
    {
        yield return new WaitForSeconds(5f);
        hideButton.SetActive(true);
    }

    
}
