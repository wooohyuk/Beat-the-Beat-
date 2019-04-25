using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_bgmmanager : MonoBehaviour
{
    public AudioSource audioSrc;

    public AudioClip clip_a;
    public AudioClip clip_b;
    public AudioClip clip_c;
    public AudioClip clip_d;

    int bc = 1;

    public void SetVolume(float vol)
    {
        VolumeChanger.musicVolume = vol;
    }

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = VolumeChanger.musicVolume;
        if (Select_Box.kimozzi == 1)
        {
            if (audioSrc.clip != clip_a)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_a);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
        if (Select_Box.kimozzi == 2)
        {
            if (audioSrc.clip != clip_b)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_b);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
        if (Select_Box.kimozzi == 3)
        {
            if (audioSrc.clip != clip_c)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_c);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
        if (Select_Box.kimozzi == 4)
        {
            if (audioSrc.clip != clip_d)
            {
                bc = 1;
                if (bc == 1)
                {
                    audioSrc.clip = (clip_d);
                    audioSrc.Play();
                    bc = 0;
                }
            }
        }
    }


}

