using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManager : MonoBehaviour
{
    public List<Sound> sounds;
    public static SoundManager  soundManager;
    
    public void Awake()
    {
        if (soundManager == null)
            soundManager = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
        }
    }

    public void Play(string name)
    {
        foreach (Sound sound in sounds)
        {
            if(sound.name == name)
            {
                sound.source.Play();
                break;
            }
            else
            {
                continue;
            }
        }
    }
    public AudioSource getSource(string name)
    {
        AudioSource source = null;
        foreach (Sound sound in sounds)
        {
            if (sound.name == name)
            {
                source = sound.source;
                break;
            }
            else
            {
                continue;
            }
        }
        return source;
    }
}
