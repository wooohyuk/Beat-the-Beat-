using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSound_Changer : MonoBehaviour
{
    private AudioSource audioSrc;


    bool check = false;

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
        if (VolumeChanger.musicVolume == 1)
        {
            VolumeChanger.musicVolume = 0;
            check = true;
        }
        if (check == true)
        {
            VolumeChanger.musicVolume += 0.0007f;
            if (VolumeChanger.musicVolume == 1.0f)
            {
                check = false;
            }
        }

        audioSrc.volume = VolumeChanger.musicVolume;
    }


}

