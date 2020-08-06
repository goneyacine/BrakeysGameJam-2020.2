using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class BackgroundSoundManager : MonoBehaviour
{
 
   private AudioSource source;
    [Range(0,1)]
   public float outsideVolume;
    [Range(.3f,3f)]
   public float outsidePitch;
    [Range(0,1)]
   public float insideVolume;
    [Range(.3f,3f)]
   public float insidePitch;


    private void Start()
    {
        FindObjectOfType<SoundManager>().Play("background sounds");
        source = FindObjectOfType<SoundManager>().getSource("background sounds");
        source.pitch = insidePitch;
        source.volume = insideVolume;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            source.volume = outsideVolume;
            source.pitch = outsidePitch;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            source.volume = insideVolume;
            source.pitch = insidePitch;
        }
    }
}
