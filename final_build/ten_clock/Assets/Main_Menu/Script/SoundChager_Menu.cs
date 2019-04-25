using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundChager_Menu : MonoBehaviour {

   
    public AudioSource audioSrcc;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        audioSrcc.volume = VolumeChanger.musicVolume;
    }
}

