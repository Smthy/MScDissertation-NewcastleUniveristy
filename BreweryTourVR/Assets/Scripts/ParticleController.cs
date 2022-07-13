using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem[] particleSystems;
    private void Awake()
    {
        foreach (var item in particleSystems)
        {
            item.Play();
        }
    }
}
