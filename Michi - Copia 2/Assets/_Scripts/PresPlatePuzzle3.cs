using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresPlatePuzzle3 : MonoBehaviour
{
    public ParticleSystem colorBase;
    public ParticleSystem colorBox;
    public ParticleSystem burst;
    public Rigidbody rb;
    public static bool part4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BoatPart4"))
        {
            part4 = true;
            this.rb.isKinematic = true;
            burst.Play();
            colorBase.Stop();
            colorBox.Stop();
        }
    }
}
