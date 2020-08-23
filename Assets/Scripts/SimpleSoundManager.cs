using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSoundManager : MonoBehaviour
{
    public static AudioClip incorrectSound, correctSound;
    static AudioSource audioSrc;

    void Start()
    {
        incorrectSound = Resources.Load<AudioClip>("Sounds/incorrectSound2");
        correctSound = Resources.Load<AudioClip>("Sounds/correctSound2");
        audioSrc = GetComponent<AudioSource>();
    }
    public static void playIncorrectSound()
    {
        audioSrc.PlayOneShot(incorrectSound);
    }
    public static void playCorrectSound()
    {
        audioSrc.PlayOneShot(correctSound);
    }
}
