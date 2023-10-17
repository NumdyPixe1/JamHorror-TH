using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip audioClip;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void PlaySound()
    {
        audioSource.Play();
        //audioClip.P
    }
    void Update()
    {

    }
}
