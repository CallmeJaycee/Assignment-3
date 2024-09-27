using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource introMusic;       
    public AudioSource mainBackgroundMusic; 

    void Start()
    {
        if (introMusic != null)
        {
            introMusic.Play();
            StartCoroutine(PlayMainBackgroundAfterIntro());
        }
        else
        {
            Debug.LogWarning("Intro music is not assigned.");
        }
    }
    private System.Collections.IEnumerator PlayMainBackgroundAfterIntro()
    {
        yield return new WaitForSeconds(introMusic.clip.length);
        if (mainBackgroundMusic != null)
        {
            mainBackgroundMusic.Play();
        }
        else
        {
            Debug.LogWarning("Main background music is not assigned.");
        }
    }
}

