using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    // An array of Sound objects to represent individual sounds that can be played in the game
    public Sound[] sounds;

    // Awake is called when the script instance is being loaded, and is there to allow easier manipulation of the sounds in the Sound array via the Unity Editor
    void Awake()
    {
        // For each Sound object in the sounds array
        foreach (Sound s in sounds) {
            
            s.source = gameObject.AddComponent<AudioSource>();
            // Set the clip, volume, pitch, and loop properties of the AudioSource to match the Sound object
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Play a sound with the specified name
    public void play(string name)
    {
        // Find the Sound object in the sounds array with the specified name
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        // If the Sound object is found, play the sound
        if (s != null) {
            s.source.Play();
        } else {
            Debug.Log("Sound " + name + " Not found");
        }
    }
}
