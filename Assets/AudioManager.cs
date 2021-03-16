using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;


    void Awake()
    {

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            //s.source.playOnAwake();
    
        }
        
    }
    private void Start()
    {
        sounds[0].source.Play();
    }
    /*
        public void changeMusic(Sound newSound, Sound inPlaySound)
        {
            if (!newSound.source.isPlaying)
            {
                inPlaySound.source.Stop();
                newSound.source.Play();
            }
        }
        */
}
