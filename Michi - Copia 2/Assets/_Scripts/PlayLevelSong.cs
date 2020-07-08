using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayLevelSong : MonoBehaviour
{
    public AudioMixer audiomMixer;
    public AudioSource songs;

    public void ChangeSongs1to2(AudioClip music2)
    {
        songs.Stop();
        songs.clip = music2;
        songs.Play();
    }
    public void ChangeSongs2to3(AudioClip music3)
    {
        songs.Stop();
        songs.clip = music3;
        songs.Play();
    }

    public void AudioControllMusics(float volume)
    {
        audiomMixer.SetFloat("musicsSounds", volume);
    }
    public void AudioControllVFX(float volume)
    {
        audiomMixer.SetFloat("vfxSounds", volume);
    }
}
