using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Menu_BGM : MonoBehaviour
{

    public AudioSource audioo;
    public AudioClip jumpSound;


    bool check = true;
    // Use this for initialization
    void Start()
    {

        this.audioo = this.gameObject.AddComponent<AudioSource>();
        this.audioo.clip = this.jumpSound;
        this.audioo.volume = 0f;
        this.audioo.Play();
        this.audioo.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == true)
        {
            if (audioo.volume == 1)
            {
                this.audioo.volume += 0.0005f;
                if (this.audioo.volume == 1.0f)
                {
                    check = false;
                }
            }
        }
    }
}
