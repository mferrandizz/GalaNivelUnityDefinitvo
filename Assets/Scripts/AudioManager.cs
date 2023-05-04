using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    private AudioSource _audiosource;
    public AudioClip jumpSFX;
    public AudioClip laserSFX;
    public AudioClip turretShotSFX;
    public AudioClip impactShotSFX;
    public AudioClip deathSFX;



    void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    public void JumpSound()
    {
        _audiosource.PlayOneShot(jumpSFX);
    }

    public void LaserSound()
    {
        _audiosource.PlayOneShot(laserSFX);
    }

    public void TurretShotSound()
    {
        _audiosource.PlayOneShot(turretShotSFX);
    }

    public void ShotHitSound()
    {
        _audiosource.PlayOneShot(impactShotSFX);
    }

    public void GameOverSound()
    {
        _audiosource.PlayOneShot(deathSFX);
    } 

}
