using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor1 : MonoBehaviour
{
    public AudioSource open;
    public Animator anim;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && GameManager.currentSouls >= 7)
        {
            anim.SetBool("hasSouls", true);
            open.Play();
        }
    }
}
