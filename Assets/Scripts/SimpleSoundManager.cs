using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSoundManager : MonoBehaviour
{
    public static AudioClip incorrectSound, correctSound, nextLevelSound, answerSound, scene1Intro, scene2Intro;
    static AudioSource audioSrc;

    void Start()
    {
        incorrectSound = Resources.Load<AudioClip>("Sounds/incorrectSound2");
        correctSound = Resources.Load<AudioClip>("");
        nextLevelSound = Resources.Load<AudioClip>("Sounds/nextLevel");

        // answers
        // animals
        //  catSound = Resources.Load<AudioClip>("Cat");



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
    public static void playNextLevelSound()
    {
        //   audioSrc.PlayOneShot(nextLevelSound);
    }

    // answers

    // animal names
    public static void playAnswerSound(string answerText)
    {
        answerSound = Resources.Load<AudioClip>("Sounds/" + answerText);

        audioSrc.PlayOneShot(answerSound);
    }

    public static void playScene1Intro()
    {
        scene1Intro = Resources.Load<AudioClip>("Sounds/Scene001Intro");
        audioSrc.PlayOneShot(scene1Intro);
    }

    public static void playScene2Intro()
    {
        scene2Intro = Resources.Load<AudioClip>("Sounds/Scene002Intro");
        audioSrc.PlayOneShot(scene2Intro);
    }
}
