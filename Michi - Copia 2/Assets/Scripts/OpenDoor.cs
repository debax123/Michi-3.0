using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    public AudioSource door;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && GameManager.currentFish >= 7)
        {
            anim.SetBool("hasFish", true);
            GameManager.level1 = false;
            GameManager.level2 = true;
            door.Play();
        }
    }
}
