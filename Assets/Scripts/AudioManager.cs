using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource introMusic;
    public AudioSource ghostNormalMusic;
    public AudioSource ghostScaredMusic;
    public AudioSource ghostDeadMusic;
    public AudioSource pacStudentMoveSound;
    public AudioSource pelletEatenSound;
    public AudioSource wallCollisionSound;
    public AudioSource pacStudentDeathSound;

    void Start()
    {
        
        introMusic.Play();
        PlayGhostNormalMusic();
        
    }

    public void PlayGhostNormalMusic()
    {
        ghostNormalMusic.Play();
        ghostScaredMusic.Stop();
        ghostDeadMusic.Stop();
    }

    public void PlayGhostScaredMusic()
    {
        ghostScaredMusic.Play();
        ghostNormalMusic.Stop();
    }

    public void PlayGhostDeadMusic()
    {
        ghostDeadMusic.Play();
        ghostNormalMusic.Stop();
    }

    public void PlayPacStudentMoveSound()
    {
        pacStudentMoveSound.Play();
    }

    public void PlayPelletEatenSound()
    {
        pelletEatenSound.Play();
    }

    public void PlayWallCollisionSound()
    {
        wallCollisionSound.Play();
    }

    public void PlayPacStudentDeathSound()
    {
        pacStudentDeathSound.Play();
    }
}
