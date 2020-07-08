using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresPlatePuzzle : MonoBehaviour
{
    public ParticleSystem colorBase;
    public ParticleSystem colorBox;
    public ParticleSystem burst;
    public Rigidbody rb;
    public static bool part1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BoatPart1"))
        {
            part1 = true;
            this.rb.isKinematic = true;
            burst.Play();
            colorBase.Stop();
            colorBox.Stop();
        }
    }
}
