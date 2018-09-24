using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour
{
    public AudioSource playMe;
    private AudioSource[] allAudioSources;

    public void clickMe()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }

        playMe.Play();
    }
}
