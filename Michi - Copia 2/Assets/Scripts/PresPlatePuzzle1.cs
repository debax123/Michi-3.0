using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresPlatePuzzle1 : MonoBehaviour
{
    public ParticleSystem colorBase;
    public ParticleSystem colorBox;
    public ParticleSystem burst;
    public Rigidbody rb;
    public static bool part2;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BoatPart2"))
        {
            part2 = true;
            this.rb.isKinematic = true;
            burst.Play();
            colorBase.Stop();
            colorBox.Stop();
        }
    }
}
