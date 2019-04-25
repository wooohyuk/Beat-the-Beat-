using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BGM_MANAGER : MonoBehaviour {
    Image Circle_1;
    public Scrollbar scrollbar; //앞 부분 퍼블릭으로 바꿔도 됨
    // Use this for initialization
    int int_a = 1;
    float value;
    public AudioSource audio;
    public AudioClip jumpsound;

    void Start () {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.volume = 0f;
        this.audio.Play();
        this.audio.loop = true;
    }
	
	// Update is called once per frame
	void Update () {
        //if (int_a == 1)
        //{
        //    this.audio.volume += 0.0005f;
        //    if (this.audio.volume == 1.0f)
        //    {
        //        int_a = 0;
        //    }
        //}
        value = scrollbar.value;
        this.audio.volume = value;
	}
}

