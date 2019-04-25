using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	bool notStart;
	private AudioSource myAudio;
    public AudioClip gameSound;

	public static AudioManager instance;

	void Start () 
	{
		notStart = true;
		myAudio = gameObject.AddComponent<AudioSource> ();
        myAudio.loop = false;
	}
	
	public void StartAudio () 
	{
		if(notStart)
		{
			myAudio.PlayOneShot(gameSound);
			notStart = false;
		}
	}
}
