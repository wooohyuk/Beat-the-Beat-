using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOO_player : MonoBehaviour
{

    public AudioSource audioSrc;

    public AudioClip clip_a;

    int bc = 1;

    bool notStart;

    public static AudioManager instance;

    bool finish;

    float music_timer = 0f;

    public void SetVolume(float vol)
    {
        VolumeChanger.musicVolume = vol;
    }

    void Start()
    {
        finish = false;
        audioSrc = GetComponent<AudioSource>();
        notStart = true;
        audioSrc = gameObject.AddComponent<AudioSource>();
        audioSrc.loop = false;
    }

    public void StartAudio()
    {
        audioSrc.volume = VolumeChanger.musicVolume;
        if (notStart)
        {
            audioSrc.PlayOneShot(clip_a);
            notStart = false;
        }
    }

    public void PauseAudio()
    {
        audioSrc.Pause();
    }

    public void UnPauseAudio()
    {
        audioSrc.UnPause();
    }

    public void Finishmusic()
    {
        finish = true;
    }

   void Update()
    {
        if (finish == true)
        {
            music_timer += Time.deltaTime;
            if (music_timer > 0.08f)
            {
                //audioSrc.volume -= 0.03f;
                audioSrc.volume -= 0.01f;
                music_timer = 0;
            }
        }    
    }
}
