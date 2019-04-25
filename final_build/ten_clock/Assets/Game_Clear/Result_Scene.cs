using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result_Scene : MonoBehaviour {


    public void retry()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        SceneManager.LoadScene("3_Loding");
    }

    public void music_seclct()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1f;
        SceneManager.LoadScene("2_1_Game_Start");
    }

    public void music_retry_seven()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1f;
        SceneManager.LoadScene("4_Ingame1");
    }

    public void music_retry_Cake()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1f;
        SceneManager.LoadScene("4_Ingame2");
    }

    public void music_retry_FeelSoGood()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1f;
        SceneManager.LoadScene("4_Ingame3");
    }

    public void music_retry_CoverItUp()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1f;
        SceneManager.LoadScene("4_Ingame4");
    }

    public void music_retry_dontno()
    {
        GameObject.Find("SEPlayer_Menu").GetComponent<Soundclip_Changer>().Return();
        Time.timeScale = 1f;
        if(StaticHome.musicName == "Seven")
        {
            SceneManager.LoadScene("4_Ingame1");
        }
        else if (StaticHome.musicName == "Cake")
        {
            SceneManager.LoadScene("4_Ingame2");
        }
        else if (StaticHome.musicName == "FeelSoGood")
        {
            SceneManager.LoadScene("4_Ingame3");
        }
        else if (StaticHome.musicName == "CoverItUp")
        {
            SceneManager.LoadScene("4_Ingame4");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
