using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsSounds : MonoBehaviour
{
    public AudioSource steps;
    public AudioClip steps1;
    public AudioClip steps2;
    public AudioClip run;
    public AudioClip run2;
    public AudioClip jump;

    public void PlaySteps()
    {
        steps.clip = steps1;
        steps.volume = 0.5f;
        steps.Play();
    }
    public void PlaySteps2()
    {
        steps.clip = steps2;
        steps.volume = 0.5f;
        steps.Play();
    }
    public void PlayRun()
    {
        steps.clip = run;
        steps.volume = 0.5f;
        steps.Play();
    }
    public void PlayRun2()
    {
        steps.clip = run2;
        steps.volume = 0.5f;
        steps.Play();
    }
    public void PlayJump()
    {
        steps.clip = jump;
        steps.Play();
    }
}
