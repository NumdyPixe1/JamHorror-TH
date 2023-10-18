using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Random random;
    public AudioSource dice;
    public AudioSource BGM;

    void Start()
    {
        random = GetComponent<Random>();

        dice = GetComponent<AudioSource>();
        BGM = GetComponent<AudioSource>();

        BGM.Play();
        DontDestroyOnLoad(BGM);
    }

    public void PlaySound()
    {
        if (random.isWait == true && random.isCheckResult == true)
        {
            dice.Play();

        }

    }

    void Update()
    {

    }
}
