using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLevelSong : MonoBehaviour
{
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
}
