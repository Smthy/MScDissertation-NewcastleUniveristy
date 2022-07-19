using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ParticleOnObjects : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem[] particles;
    public GameObject wall;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            wall.SetActive(false);
            foreach (var item in particles)
            {
                item.Play();
            }
        }
    }
}
