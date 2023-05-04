using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    private AudioSource _audiosource;


    void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    void Start()
    {
        _audiosource.Play();
    }

    public void StopBGM()
    {
        _audiosource.Stop();
    }


}
