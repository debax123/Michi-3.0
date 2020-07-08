using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWater : MonoBehaviour
{
    public AudioSource sea;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sea.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(sea.isPlaying)
            {
                sea.Stop();
            }
        }
    }
}
