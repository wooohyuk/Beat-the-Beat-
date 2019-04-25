using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeChanger : MonoBehaviour
{
    public UnityEngine.UI.Scrollbar Circle_1;
    private AudioSource audioSrc;

    static float sound = 1;

    //int int_a = 1;

    public static float musicVolume = 1f;

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    void Start()
    {
        Circle_1.value = sound;
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        sound = Circle_1.value;
        audioSrc.volume = musicVolume;
    }


}

