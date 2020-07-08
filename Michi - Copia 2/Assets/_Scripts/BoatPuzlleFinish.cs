using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPuzlleFinish : MonoBehaviour
{
    public static bool complete;
    // Start is called before the first frame update
    void Start()
    {
        complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((PresPlatePuzzle.part1) && (PresPlatePuzzle1.part2) && (PresPlatePuzzle2.part3) && (PresPlatePuzzle3.part4))
        {
            complete = true;
        }
    }
}
