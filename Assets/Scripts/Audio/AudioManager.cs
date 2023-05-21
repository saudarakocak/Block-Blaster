using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] Audio;

    private void Awake()
    {
        foreach(Sound x in Audio)
        {
            x.Source = gameObject.AddComponent<AudioSource>();

            x.Source.clip = x.audioClip;
            x.Source.volume = x.volume;
            x.Source.pitch = x.pitch;
            x.Source.loop = x.loop;
        }
    }


    public void Play(string name)
    {
        Sound i = Array.Find(Audio, Sound => Sound.name == name);
        i.Source.Play();    

        if (name == null)
        {
            Debug.Log("Audio Cant Found :(");
            return;
        }
    }

    public void Stop(string name)
    {
        Sound i = Array.Find(Audio, Sound => Sound.name == name);
        i.Source.Stop();

        if (name == null)
        {
            Debug.Log("Audio Cant Found :(");
            return;
        }
    }
}
