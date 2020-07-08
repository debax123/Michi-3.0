using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesStart : MonoBehaviour
{
    public ParticleSystem part;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (GameManager.level3)
        {
            part.Play();
        }
    }
}
