using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSongs : MonoBehaviour
{
    public AudioClip newTrack;

    private PlayLevelSong theAM;
    // Start is called before the first frame update
    void Start()
    {
        theAM = FindObjectOfType<PlayLevelSong>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.gameObject.CompareTag("Lvl2"))
        {
            if(newTrack != null)
            {
                theAM.ChangeSongs1to2(newTrack);
            }
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("Lvl3"))
        {
            if(newTrack != null)
            {
                theAM.ChangeSongs1to2(newTrack);
            }
        }
    }
}
