using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_Control : MonoBehaviour {

	public GameObject pausePanel;
	void Start () 
	{
		pausePanel.SetActive(false);
	}

	public void PressPause() //버튼 눌렀을 때
	{
		pausePanel.SetActive(true);
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 0;
        GameObject.Find("MusicPlayer").GetComponent<WOO_player>().PauseAudio();
    }

	public void ExitPause()
	{
		pausePanel.SetActive(false);
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1;
        GameObject.Find("MusicPlayer").GetComponent<WOO_player>().UnPauseAudio();
    }

	public void GotoMain()
	{

	}

	public void GotoRetry()
	{

	}
}
