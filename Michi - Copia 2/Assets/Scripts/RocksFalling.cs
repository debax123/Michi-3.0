using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksFalling : MonoBehaviour
{
    public AudioSource fall;
    public GameObject rocks;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            rocks.SetActive(true);
            fall.Play();
        }
    }
}
