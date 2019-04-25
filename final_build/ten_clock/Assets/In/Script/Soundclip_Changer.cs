using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundclip_Changer : MonoBehaviour
{

    public AudioSource audioSrc;

    public AudioClip clip_read;
    public AudioClip clip_return;
    public AudioClip clip_third;

    public static int hotsix = 0;

    public void Read()
    {
        audioSrc.clip = null;
        hotsix = 1;
    }

    public void Return()
    {
        audioSrc.clip = null;
        hotsix = 2;
    }

    public void Third()
    {
        audioSrc.clip = null;
        hotsix = 3;
    }

    int bc = 1;

    public void SetVolume(float vol)
    {
        SEChanger.musicVolume = vol;
    }

    void Start()
    {
        hotsix = 0;
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = SEChanger.musicVolume;
        if (hotsix == 1)
        {
            if (audioSrc.clip != clip_read)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_read);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
        if (hotsix == 2)
        {
            if (audioSrc.clip != clip_return)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_return);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
        if (hotsix == 3)
        {
            if (audioSrc.clip != clip_third)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_third);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
    }
}
