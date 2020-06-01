using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresPlatePuzzle2 : MonoBehaviour
{
    public ParticleSystem colorBase;
    public ParticleSystem colorBox;
    public ParticleSystem burst;
    public Rigidbody rb;
    public static bool part3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BoatPart3"))
        {
            part3 = true;
            this.rb.isKinematic = true;
            burst.Play();
            colorBase.Stop();
            colorBox.Stop();
        }
    }
}
