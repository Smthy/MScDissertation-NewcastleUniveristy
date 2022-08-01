using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    public GameObject spin;
    private float speed = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spin.transform.Rotate(0, speed, 0, Space.Self);
    }
}
